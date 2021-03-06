﻿using System.ComponentModel.DataAnnotations;

namespace HRCentral.Web.Models.Qualifications
{
    public class NewQualificationViewModel
    {
        [RegularExpression(@"^[a-zA-Z]*$", ErrorMessage = "Qualification title contains only Characters.")]
        [Display(Name = "Qualification Title")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "Qualification title must be atleast 3 characters long.")]
        [Required]
        public string Title { get; set; }
    }
}