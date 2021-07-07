using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HubLockerAPI.Data.Data;
using HubLockerAPI.Data.DataAccess.Interfaces;
using HubLockerAPI.Helper.Extensions;
using HubLockerAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace HubLockerAPI.Data.DataAccess.Implementation
{
    public class LocationRepo : GenericRepository<Location>, ILocationRepo
    {
        private readonly ApplicationDbContext _ctx;
        private readonly DbSet<Location> _entity;

        public LocationRepo(ApplicationDbContext ctx) : base(ctx)
        {
            _ctx = ctx;
            _entity = _ctx.Set<Location>();
        }


        public async Task<Location> GetLocationById(Guid locationId)
        {
            var location = await _ctx.Locations.Include(model => model.Lockers)
                .FirstOrDefaultAsync(m => m.Id == locationId);

            return location;
        }
        public async Task<IEnumerable<Location>> GetAllLocationsWithLockers(string searchTerm)
        {
            var locations = await _ctx.Locations.Include(model => model.Lockers).Search(searchTerm).ToListAsync();

            return locations;
        }
    }
}
