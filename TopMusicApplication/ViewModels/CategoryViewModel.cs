﻿using DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMusicCommon;

namespace TopMusicApplication.ViewModels
{
    public class CategoryViewModel
    {
        //Creation
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 10)]
        public string Description { get; set; }

        //Edit
        public int Category_ID { get; set; }

        //Edit
        public CategoryVisibility Visibility { get; set; }
        public Category Category { get; set; }

        //Index
        public string Image { get; set; }




    }
}
