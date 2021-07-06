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
    [Route("api/location/{locationId}/lockers")]
    [ApiController]
    public class LockerController : ControllerBase
    {
      
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetLockers()
        {
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        // GET: LocationController/Details/5
        public IActionResult Details(int id)
        {
            return Ok();
        }

        [HttpPost]

        // GET: LocationController/Create
        public IActionResult Create()
        {
            return Ok();
        }

        [HttpPost]
        [Route("{id}")]
        // GET: LocationController/Edit/5
        public ActionResult Edit(int id)
        {
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        // GET: LocationController/Delete/5
        public IActionResult Delete(int id)
        {
            return Ok();
        }

    }
}
