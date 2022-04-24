﻿using MeetupWebAPI.BLL.DTO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetupWebAPI.BLL.DTO.Meetup
{
    public class MeetupDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string TagText { get; set; }

        public string Place { get; set; }

        public DateTime Date { get; set; }

        public List<UserDTO> Users { get; set; }
    }
}
