using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocPatientPortal.Controllers
{
    public class OrganController : Controller
    {
        public IActionResult OrgDonate()
        {
            return View();
        }
        public IActionResult OrgSearch()
        {
            return View();
        }

    }
}
