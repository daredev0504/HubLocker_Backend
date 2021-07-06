using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubLockerAPI.Models.DTOs
{
    public class LocationReadDto
    {
        public Guid Id { get; set; }

        public string City { get; set; } 

        public string State { get; set; }
    }
}
