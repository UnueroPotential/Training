﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Training.Data
{
    public class AspUser:IdentityUser
    {
        public string Description { get; set; }

    }
}
