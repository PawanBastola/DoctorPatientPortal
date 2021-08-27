using DocPatientPortal.Models;
using Microsoft.AspNetCore.Http;
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


        public IActionResult Index(int did)
        {

            if (HttpContext.Session.GetString("Logged") == "true")
            {

            var docData = dal.Doctors.Find(did);
            ViewBag.ViewProfile = docData;
            return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

       

        

        

    }
}