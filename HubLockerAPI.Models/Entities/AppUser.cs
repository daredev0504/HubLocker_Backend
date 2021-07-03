using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace HubLockerAPI.Models.Entities
{
    public class AppUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; } 

        [Required]
        public string LastName { get; set; }
        public string Country { get; set; }
    }
}
