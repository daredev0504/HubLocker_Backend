﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubLockerAPI.Models.DTOs
{
    public class LockerCreateDto
    {
        [Required]
        public string Name { get; set; }
        public string Size { get; set; }
    }
}
