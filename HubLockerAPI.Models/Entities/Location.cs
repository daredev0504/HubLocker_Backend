using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubLockerAPI.Models.Entities
{
    public class Location
    {
        [Required]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "City name is a required field.")]
        public string City { get; set; } 

        [Required(ErrorMessage = "State name is a required field.")]
        public string State { get; set; }

        // Navigational Properties
        private ICollection<Locker> Lockers { get; set; } = new List<Locker>();
    }
}
