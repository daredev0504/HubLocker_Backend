using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HubLockerAPI.Models.Entities;

namespace HubLockerAPI.Data.DataAccess.Interfaces
{
    public interface ILockerRepo : IGenericRepository<Locker>
    {
        Task<ICollection<Locker>> GetLockersByPageNumber(int pageNumber, int per_page);
    }
}
