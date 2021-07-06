using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HubLockerAPI.Data.DataAccess.Interfaces;
using HubLockerAPI.Helper.RequestFeatures;
using HubLockerAPI.Models;
using HubLockerAPI.Models.DTOs;
using HubLockerAPI.Services.Interfaces;

namespace HubLockerAPI.Services.Implementation
{
    public class LockerService : ILockerService
    {
        private readonly ILockerRepo _lockerRepo;

        public LockerService(ILockerRepo lockerRepo, IMapper mapper)
        {
            _lockerRepo = lockerRepo;
        }
        public Task<Response<PagedList<LockerReadDto>>> GetLockersByPages(int pageNumber)
        {
            throw new NotImplementedException();
        }

        public Task<Response<LockerReadDto>> RetrieveLockerById(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<LockerReadDto>> AddLocker(LockerCreateDto model)
        {
            var locker = 
            _lockerRepo.Add(lockerDomain);
        }

        public Task<Response<string>> EditLocker(string id, LockerUpdateDto model)
        {
            throw new NotImplementedException();
        }

        public Task<Response<string>> DeleteLocker(string id)
        {
            throw new NotImplementedException();
        }
    }
}
