﻿using ParamApi.Base.Attribute;
using ParamApi.Base.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ParamApi.Dto.Dtos
{
    public class PersonDto : BaseDto
    {

        [Required]
        [MaxLength(25)]
        [Display(Name = "StaffId")]
        public string StaffId { get; set; }

        [Required]
        [MaxLength(500)]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(500)]
        [Display(Name = "LastName")]
        public string LastName { get; set; }

        [EmailAddress]
        [MaxLength(500)]
        public string Email { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Phone]
        [MaxLength(25)]
        public string Phone { get; set; }

        [Required]
        [DateOfBirthAttiribute]
        [DataType(DataType.Date)]
        [Display(Name = "DateOfBirth")]
        public DateTime DateOfBirth { get; set; }


        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
    }
}
