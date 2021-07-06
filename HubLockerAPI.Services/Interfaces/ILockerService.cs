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
        Task<Response<PagedList<LockerReadDto>>> GetLockersByPages(int pageNumber);
        Task<Response<LockerReadDto>> RetrieveLockerById(string Id);
        Task<Response<LockerReadDto>> AddLocker(LockerCreateDto model);
        Task<Response<string>> EditLocker(string id, LockerUpdateDto model);
        Task<Response<string>> DeleteLocker(string id);  
    }
}
