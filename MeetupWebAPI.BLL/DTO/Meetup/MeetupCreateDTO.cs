﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetupWebAPI.BLL.DTO.Meetup
{
    public class MeetupCreateDTO
    {
        [Display(Name = "Name")]
        [Required(ErrorMessage="Name must be filled!")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Tags")]
        public string TagText { get; set; }

        [Display(Name="Place")]
        [Required(ErrorMessage="Place must be filled!")]
        public string Place { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "Date must be filled!")]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }
    }
}
