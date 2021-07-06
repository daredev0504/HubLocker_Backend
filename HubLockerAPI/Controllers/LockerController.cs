using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HubLockerAPI.Helper.RequestFeatures;
using HubLockerAPI.Models;
using HubLockerAPI.Models.DTOs;
using HubLockerAPI.Services.Interfaces;
using Newtonsoft.Json;

namespace HubLockerAPI.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/location/{locationId}/lockers")]
    [ApiController]
    public class LockerController : ControllerBase
    {
        private readonly ILockerService _lockerService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lockerService"></param>
        public LockerController(ILockerService lockerService)
        {
            _lockerService = lockerService;
        }

       
        /// <summary>
        /// gets paginated lockers by location
        /// </summary>
        /// <param name="locationId"></param>
        /// <param name="lockerParameters"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetPaginatedLockers(Guid locationId, [FromQuery] LockerParameters lockerParameters)
        {
            var result = await _lockerService.GetLockersByPages(locationId, lockerParameters);

            if (result.Success)
            {
                Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(result.Data.MetaData));

                return Ok(result.Data);
            }
            return BadRequest();
        }


        /// <summary>
        /// Get a locker by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "GetLocationById")]
        public async Task<IActionResult> GetLockerById(Guid id)
        {
            var result = await _lockerService.RetrieveLockerById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="locationId"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateLocker(Guid locationId, [FromBody]LockerCreateDto model)
        {
            var result = await _lockerService.AddLocker(locationId, model);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        
        }

      
        /// <summary>
        /// Update a Locker
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("{id}")]
        
        public async Task<IActionResult> EditLocker(Guid id, LockerUpdateDto model)
        {
            var result = await _lockerService.EditLocker(id, model);
            if (result.Success)
            {
                return NoContent();
            }
            return BadRequest();
        }

        /// <summary>
        /// Delete a Locker
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}")]
        // GET: LocationController/Delete/5
        public async Task<IActionResult> DeleteLocker(Guid id)
        {
            var result = await _lockerService.DeleteLocker(id);
            if (result.Success)
            {
                return NoContent();
            }
            return BadRequest();
        }

    }
}
