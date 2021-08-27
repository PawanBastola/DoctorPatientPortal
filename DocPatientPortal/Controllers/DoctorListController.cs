using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DocPatientPortal.Controllers
{
    public class DoctorListController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Logged") == "true")
            {
            return View();

            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}
