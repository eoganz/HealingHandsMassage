﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MassageSite.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        private string Password { get; set; }
    }

}