﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.Domain.Models
{
    public class User
    {
        public int id { get; set; }
        public string? Email { get; set; }
        public string? Username { get; set; }
    }
}
