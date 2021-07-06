using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HubLockerAPI.Helper.RequestFeatures;
using HubLockerAPI.Models;
using HubLockerAPI.Models.DTOs;

namespace HubLockerAPI.Services.Interfaces
{
    public interface ILockerService
    {
        Task<Response<PagedList<LockerReadDto>>> GetLockersByPages(Guid locationId, LockerParameters lockerParameters);
        Response<IEnumerable<LockerReadDto>> GetLockersByLocation(Guid locationId);
        Task<Response<LockerReadDto>> RetrieveLockerById(Guid id);
        Task<Response<LockerReadDto>> AddLocker(Guid locationId, LockerCreateDto model);
        Task<Response<string>> EditLocker(Guid id, LockerUpdateDto model);
        Task<Response<string>> DeleteLocker(Guid id);  
    }
}
