﻿using System.ComponentModel.DataAnnotations;

namespace CarAgency.ViewModels
{
    public class roleVM
    {
        [Display(Name = "Role Name")]
        public string Name { get; set; }
    }
}