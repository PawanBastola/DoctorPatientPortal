using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DocPatientPortal.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

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
        public IActionResult LoginCheck(String username, String password)
        {
            var user_List = dal.userlogins.Where(x => x.username.Equals(username)).ToList();

            #region IF admin role check

            if (user_List.Count() == 1 && user_List[0].password.Equals(password) && user_List[0].role.Equals("admin"))
            {
                //admin role
                //setting session using HttpContext

               /* HttpContext.Session.SetString("User", JsonConvert.SerializeObject(user_List[0])); //note argument should be in strings only.
                HttpContext.Session.SetString("Logged", "true");*/

                //HttpContext.Session.SetString("password",password);
                return RedirectToAction("View_Appointment", "Admin_Appointment");
            }
            #endregion
            #region ELSE IF patient role check

            else if (user_List.Count() == 1 && user_List[0].password.Equals(password) && user_List[0].role.Equals("patient"))
            {
                //doctor role
                return RedirectToAction("ApptBook", "Appointment");
            }
            #endregion
            else
            {
                TempData["error"] = "invalid credentials";
                return RedirectToAction("Index", "Login");
            }

        }

        //yo action kai call vako xaina.
        public IActionResult Logout()
        {
            HttpContext.Session.SetString("User", "null");
            HttpContext.Session.SetString("Logged", "null");
            return RedirectToAction("Index", "Login");
        }

    }
}