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
    [Route("api/appusers")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
