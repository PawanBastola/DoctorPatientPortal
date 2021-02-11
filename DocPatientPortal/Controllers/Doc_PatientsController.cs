using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocPatientPortal.Controllers
{
    public class Doc_PatientsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
