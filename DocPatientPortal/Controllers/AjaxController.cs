using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocPatientPortal.Controllers
{
    public class AjaxController : Controller
    {

        public JsonResult myFunc()
        {
            String[] abc = { "something", "abc" };
            return Json(abc);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
