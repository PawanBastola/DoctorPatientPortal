using DocPatientPortal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocPatientPortal.Controllers
{
    public class Admin_CustomersController : Controller
    {
        DataContext dal = new DataContext();

        public IActionResult View_Customers()
        {
            if (HttpContext.Session.GetString("Logged") == "true")
            {
                var activeusers = dal.userlogins.Where(x => x.status.Equals("Active")).Where(x=>x.role=="patient").ToList();
                var patientlist = dal.Patients.ToList();
                ViewBag.customers = patientlist.Where(x=>activeusers.All(y=>y.username==x.p_username)).ToList();
                return View();

            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}
