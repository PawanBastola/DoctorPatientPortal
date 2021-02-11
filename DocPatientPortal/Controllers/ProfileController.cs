using DocPatientPortal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocPatientPortal.Controllers
{
    public class ProfileController : Controller
    {
        //create datacontext object
        DataContext dal = new DataContext();

        public IActionResult Index()
        {
            return View();
        }

        

    }
}