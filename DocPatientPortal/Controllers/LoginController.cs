using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DocPatientPortal.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginCheck()
        {
            //checking the username and password
            //write the code here and redirect to the home page if condition comes true.

            //if (username == true && password == true)
            //return Redirect("Home/Index")


            return Redirect("/Home/Index");
        }
    }
}
