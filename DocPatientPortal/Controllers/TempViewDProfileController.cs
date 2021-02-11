using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocPatientPortal.Models;

namespace DocPatientPortal.Controllers
{
    public class TempViewDProfileController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }


        
    }
}
