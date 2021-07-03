using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HubLockerAPI.Data.Data;
using HubLockerAPI.Data.DataAccess.Interfaces;
using HubLockerAPI.Helper.RequestFeatures;
using HubLockerAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace HubLockerAPI.Data.DataAccess.Implementation
{
    public class LockerRepo : GenericRepository<Locker>, ILockerRepo
    {
        private readonly ApplicationDbContext _ctx;
        public LockerRepo(ApplicationDbContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }


        public Task<PagedList<Locker>> GetLockersAsync(Guid locationId, LockerParameters parameters)
        {
            var lockers = GetAll().Where(model => model.LocationId == locationId);
            
            return Task.FromResult(PagedList<Locker>.ToPagedList(lockers,
                parameters.PageNumber,
                parameters.PageSize));
        }

    }
}
