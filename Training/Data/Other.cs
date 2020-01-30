using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Training.Data
{
    public class Other:IdentityUser
    {
        public string OtherDescription { get; set; }
    }
}
