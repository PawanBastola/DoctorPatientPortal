using Microsoft.AspNetCore.Http;
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
            if (HttpContext.Session.GetString("Logged") == "true")
            {

                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult OrgSearch()
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
