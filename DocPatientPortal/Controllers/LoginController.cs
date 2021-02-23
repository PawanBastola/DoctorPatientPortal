using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DocPatientPortal.Models;

namespace DocPatientPortal.Controllers
{
    public class LoginController : Controller
    {
        DataContext dal = new DataContext();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginCheck(UserLogin userlogins)
        {

            //checking the username and password
            //write the code here and redirect to the home page if condition comes true.

            //my logic : if username and password is matched among the rows of the database then login is successful.
            //or if table ko row has the given login information then login garne.
            if ()
            {

            }
            //if (username == true && password == true)
            //return Redirect("Home/Index")



            return Redirect("/Appointment/ApptBook");
        }
    }
}
