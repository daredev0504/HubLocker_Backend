using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubLockerAPI.Models.Entities
{
    public class Locker
    {
        [Column("LockerId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Locker name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        public string Name { get; set; }
        public string Size { get; set; }


        // Navigational Properties
        public Guid LocationId { get; set; }
        public Location Location { get; set; }
    }
}
