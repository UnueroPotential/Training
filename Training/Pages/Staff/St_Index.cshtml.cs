using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Training
{
    [Authorize(Roles = "staff")]
    public class St_IndexModel : PageModel
    {
        public void OnGet()
        {

        }
    }
}