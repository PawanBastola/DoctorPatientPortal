using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace DocPatientPortal.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Doctor_register()
        {

            return RedirectToAction("Register_message","SignUp");
        }

        public IActionResult Register_message()
        {
            return View();
        }
    }
}
