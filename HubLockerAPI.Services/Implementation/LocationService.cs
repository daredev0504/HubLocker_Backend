using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HubLockerAPI.Data.DataAccess.Interfaces;
using HubLockerAPI.Models;
using HubLockerAPI.Models.DTOs;
using HubLockerAPI.Models.Entities;
using HubLockerAPI.Services.Interfaces;

namespace HubLockerAPI.Services.Implementation
{
    public class LocationService : ILocationService
    {
        private readonly ILocationRepo _locationRepo;
        private readonly IMapper _mapper;

        public LocationService(ILocationRepo locationRepo, IMapper mapper)
        {
            _locationRepo = locationRepo;
            _mapper = mapper;
        }
        public Response<IEnumerable<LocationReadDto>> GetAllLocationsAsync()
        {
            Response<IEnumerable<LocationReadDto>> response = new Response<IEnumerable<LocationReadDto>>();
            var location = _locationRepo.GetAll();
            if (location == null)
            {
                response.Message = "Location not found";
                return response;
            }

            var locationReadDto = _mapper.Map<IEnumerable<LocationReadDto>>(location);
            response.Success = true;
            response.Message = "Location found";
            response.Data = locationReadDto;
            return response;
        }

        public async Task<Response<LocationReadDto>> RetrieveLocationById(Guid id)
        {
            Response<LocationReadDto> response = new Response<LocationReadDto>();
            var location = await _locationRepo.GetById(id);
            if (location == null)
            {
                response.Message = "Location not found";
                return response;
            }

            var locationReadDto = _mapper.Map<LocationReadDto>(location);
            response.Success = true;
            response.Message = "Location found";
            response.Data = locationReadDto;
            return response;
        }

        public async Task<Response<LocationReadDto>> AddLocation(LocationCreateDto model)
        {
            var response = new Response<LocationReadDto>();
            var locationDomain = _mapper.Map<Location>(model);

            if (await _locationRepo.Add(locationDomain))
            {
                response.Success = true;
                var locationReadDto = _mapper.Map<LocationReadDto>(locationDomain);
                response.Message = !response.Success ? "Error occured while updating your entry" : "Updated successfully";
                response.Data = locationReadDto;
                return response;
              
            }

            response.Message = "Location not found";
            response.Success = false;
            return response;

        }

        public async Task<Response<string>> EditLocation(Guid id, LocationUpdateDto model)
        {
            var response = new Response<string>();

            var locationToEdit = await _locationRepo.GetById(id);
            //end the process if the location is not found
            if (locationToEdit == null)
            {
                response.Message = "Error retrieving location";
                return response;
            }

            //updates the status of the entity class
            _mapper.Map(model, locationToEdit);
            response.Message = "Updated successfully";
            response.Success = true;
            return response;
        }

        public async Task<Response<string>> DeleteLocation(Guid id)
        {
            Response<string> response = new Response<string>();
            var locationToDelete = await _locationRepo.GetById(id);
            if (locationToDelete == null)
            {
                response.Message = "Invalid location Id";
                return response;
            }
            if (await _locationRepo.DeleteById(id))
            {
                response.Success = true;
                response.Message = "Location deleted successfully";
                return response;
            }
            response.Message = "Unable to delete location, Plese try again later";
            return response;
        }
    }
}
