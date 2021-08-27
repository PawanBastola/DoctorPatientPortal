using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocPatientPortal.Controllers
{
    public class Admin_AppointmentController : Controller
    {
        public IActionResult View_Appointment()
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
