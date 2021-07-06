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
        private readonly ILocationRepo _locationRepo;

        public LockerService(ILockerRepo lockerRepo, IMapper mapper, ILocationRepo locationRepo)
        {
            _lockerRepo = lockerRepo;
            _mapper = mapper;
            _locationRepo = locationRepo;
        }
        public async Task<Response<PagedList<LockerReadDto>>> GetLockersByPages(Guid locationId, LockerParameters lockerParameters)
        {
            Response<PagedList<LockerReadDto>> response = new Response<PagedList<LockerReadDto>>();

            var lockers = await _lockerRepo.GetLockersAsync(locationId, lockerParameters);
            if (lockers == null)
            {
                response.Message = "Lockers not found";
                return response;
            }

            response.Success = true;
            response.Message = "Locker found";
            response.Data = lockers;
            return response;
        }

        public Response<IEnumerable<LockerReadDto>> GetLockersByLocation(Guid locationId)
        {
            Response<IEnumerable<LockerReadDto>> response = new Response<IEnumerable<LockerReadDto>>();

            var lockers = _lockerRepo.GetLockersPerLocation(locationId);
            if (lockers == null)
            {
                response.Message = "Lockers not found";
                return response;
            }

            response.Success = true;
            response.Message = "Lockers found";
            response.Data = lockers;
            return response;
        }
        

        public async Task<Response<LockerReadDto>> RetrieveLockerById(Guid id)
        {
            Response<LockerReadDto> response = new Response<LockerReadDto>();
            var locker = await _lockerRepo.GetById(id);
            if (locker == null)
            {
                response.Message = "Locker not found";
                return response;
            }

            var lockerReadDto = _mapper.Map<LockerReadDto>(locker);
            response.Success = true;
            response.Message = "Locker found";
            response.Data = lockerReadDto;
            return response;
        }

        public async Task<Response<LockerReadDto>> AddLocker(Guid locationId, LockerCreateDto model)
        {
            var response = new Response<LockerReadDto>();
            var location = await _locationRepo.GetById(locationId);
            if (location == null)
            {
                response.Message = "Location not found";
                response.Success = false;
                return response;
            }
            var lockerDomain = _mapper.Map<Locker>(model);
            //updates the locationId in the LocationId property
            lockerDomain.LocationId = locationId;
           
          
            var result = await _lockerRepo.Add(lockerDomain);
            var lockerReadDto = _mapper.Map<LockerReadDto>(lockerDomain);
            response.Success = result;
            response.Message = !response.Success ? "Error occured while creating your locker in this location" : "Created successfully";
            response.Data = lockerReadDto;
            return response;

        }

        public async Task<Response<string>> EditLocker(Guid id, LockerUpdateDto model)
        {
            var response = new Response<string>();

            var lockerToEdit = await _lockerRepo.GetById(id);
            //end the process if the locker is not found
            if (lockerToEdit == null)
            {
                response.Message = "Error retrieving locker";
                return response;
            }

            //updates the status of the entity class
            _mapper.Map(model, lockerToEdit);

            response.Message = "Updated successfully";
            response.Success = true;
            return response;
        }

        public async Task<Response<string>> DeleteLocker(Guid id)
        {
            Response<string> response = new Response<string>();
            var lockerToDelete = await _lockerRepo.GetById(id);
            if (lockerToDelete == null)
            {
                response.Message = "Invalid locker Id";
                return response;
            }
            if (await _lockerRepo.DeleteById(id))
            {
                response.Success = true;
                response.Message = "Locker deleted successfully";
                return response;
            }
            response.Message = "Unable to delete locker, Plese try again later";
            return response;
        }
    }
}
