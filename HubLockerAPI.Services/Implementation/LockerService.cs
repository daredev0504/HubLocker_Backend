using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HubLockerAPI.Data.DataAccess.Interfaces;
using HubLockerAPI.Helper.RequestFeatures;
using HubLockerAPI.Models;
using HubLockerAPI.Models.DTOs;
using HubLockerAPI.Models.Entities;
using HubLockerAPI.Services.Interfaces;

namespace HubLockerAPI.Services.Implementation
{
    public class LockerService : ILockerService
    {
        private readonly ILockerRepo _lockerRepo;
        private readonly IMapper _mapper;

        public LockerService(ILockerRepo lockerRepo, IMapper mapper)
        {
            _lockerRepo = lockerRepo;
            _mapper = mapper;
        }
        public Task<Response<PagedList<LockerReadDto>>> GetLockersByPages(int pageNumber)
        {
            throw new NotImplementedException();
        }

        public Task<Response<LockerReadDto>> RetrieveLockerById(string Id)
        {
            throw new NotImplementedException();
        }

        public async Task<Response<LockerReadDto>> AddLocker(LockerCreateDto model)
        {
            var response = new Response<LockerReadDto>();
            var lockerDomain = _mapper.Map<Locker>(model);
            if ( await _lockerRepo.Add(lockerDomain))
            {
                var lockerReadDto = _mapper.Map<LockerReadDto>(lockerDomain);
                response.Success = true;
                response.Message = "locker created successfully";
                response.Data = lockerReadDto;
                return response;
            }

            response.Message = "locker failed to add";
            return response;
           
           

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
