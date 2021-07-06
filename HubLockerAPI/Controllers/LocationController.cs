using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HubLockerAPI.Models.DTOs;
using HubLockerAPI.Services.Interfaces;

namespace HubLockerAPI.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/location")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService _locationService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="locationService"></param>
        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        /// <summary>
        /// Gets a list of all Locations
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetLocations()
        {
            var result = _locationService.GetAllLocationsAsync();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }
        

        /// <summary>
        /// Gets a Location by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetLocationById(Guid id)
        {
            var result = await _locationService.RetrieveLocationById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        /// <summary>
        /// Create a Location
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateLocation(LocationCreateDto model)
        {
            var result = await _locationService.AddLocation(model);
            if (result.Success)
            {
                return CreatedAtRoute("GetLocationById", new {Id = result.Data.Id}, result.Data);
            }

            return BadRequest();
        }

        
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("{id}")]
        public async Task<IActionResult> UpdateLocation(Guid id, LocationUpdateDto model)
        {
            var result = await _locationService.EditLocation(id, model);
            if (result.Success)
            {
                return NoContent();
            }
            return BadRequest();
        }

      
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteLocation(Guid id)
        {
            var result = await _locationService.DeleteLocation(id);
            if (result.Success)
            {
                return NoContent();
            }
            return BadRequest();
        }

      
    }
}
