﻿using System;

namespace HiChef.Model.Models
{
    public class User
    {
        public Guid Guid { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
