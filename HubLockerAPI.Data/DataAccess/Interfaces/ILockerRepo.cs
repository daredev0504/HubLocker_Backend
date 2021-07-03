using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HubLockerAPI.Helper.RequestFeatures;
using HubLockerAPI.Models.Entities;

namespace HubLockerAPI.Data.DataAccess.Interfaces
{
    public interface ILockerRepo : IGenericRepository<Locker>
    {
        Task<PagedList<Locker>> GetLockersAsync(Guid companyId, LockerParameters parameters);
    }
}
