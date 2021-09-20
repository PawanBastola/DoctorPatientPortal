using DocPatientPortal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocPatientPortal.Controllers
{
    public class FeedbackController : Controller
    {
        DataContext dal = new DataContext();
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Logged") == "true")
            {
                var feedbacks = dal.feedbacks.ToList();
                ViewBag.feedbacks = feedbacks;

                //setting viewbag for role
                string role = JsonConvert.DeserializeObject<UserLogin>(HttpContext.Session.GetString("User")).role;
                ViewBag.role = role;


                return View();

            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult doctorfeedback()
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
