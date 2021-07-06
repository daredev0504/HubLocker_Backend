using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HubLockerAPI.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/location")]
    [ApiController]
    public class LocationController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetLocations()
        {
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Details(int id)
        {
            return Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create()
        {
            return Ok();
        }

        
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("{id}")]
        public ActionResult Edit(int id)
        {
            return Ok();
        }

      
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }

      
    }
}
