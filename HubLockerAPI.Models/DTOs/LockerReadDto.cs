using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubLockerAPI.Models.DTOs
{
    public class LockerReadDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
    }
}
