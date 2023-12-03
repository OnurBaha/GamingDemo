﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    public class Gamer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Identity { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
