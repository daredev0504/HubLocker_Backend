using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HubLockerAPI.Models.Entities;

namespace HubLockerAPI.Data.DataAccess.Interfaces
{
    public interface ILocationRepo : IGenericRepository<Location>
    {
        Task<Location> GetLocationById(Guid locationId);
        Task<IEnumerable<Location>> GetAllLocationsWithLockers(string searchTerm);
    }
}
