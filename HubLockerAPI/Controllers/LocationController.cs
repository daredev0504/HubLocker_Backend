using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HubLockerAPI.Controllers
{
    public class LocationController : ControllerBase
    {
        // GET: LocationController
        public IActionResult GetLocations()
        {
            return Ok();
        }

        // GET: LocationController/Details/5
        public IActionResult Details(int id)
        {
            return Ok();
        }

        // GET: LocationController/Create
        public IActionResult Create()
        {
            return Ok();
        }

        
        // GET: LocationController/Edit/5
        public ActionResult Edit(int id)
        {
            return Ok();
        }

        // GET: LocationController/Delete/5
        public IActionResult Delete(int id)
        {
            return Ok();
        }

      
    }
}
