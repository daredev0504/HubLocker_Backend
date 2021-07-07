using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubLockerAPI.Models.DTOs
{
    public class LocationCreateDto
    {

        [Required(ErrorMessage = "City name is a required field.")]
        public string City { get; set; } 

        [Required(ErrorMessage = "State name is a required field.")]
        public string State { get; set; }
        public IEnumerable<LockerCreateDto> Lockers { get; set; } = new List<LockerCreateDto>();
    }
}
