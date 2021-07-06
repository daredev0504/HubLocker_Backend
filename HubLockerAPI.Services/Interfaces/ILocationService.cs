using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HubLockerAPI.Models;
using HubLockerAPI.Models.DTOs;
using HubLockerAPI.Models.Entities;

namespace HubLockerAPI.Services.Interfaces
{
    public interface ILocationService
    {
        Response<IEnumerable<LocationReadDto>> GetAllLocationsAsync();
        Task<Response<LocationReadDto>> RetrieveLocationById(Guid id);
        Task<Response<LocationReadDto>> AddLocation(LocationCreateDto model);
        Task<Response<string>> EditLocation(Guid id, LocationUpdateDto model);
        Task<Response<string>> DeleteLocation(Guid id);  
    }
}
