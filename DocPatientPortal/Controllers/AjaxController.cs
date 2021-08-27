using DocPatientPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocPatientPortal.Controllers
{
    public class AjaxController : Controller
    {
        DataContext dal = new DataContext();
        public JsonResult myFunc()
        {
            String[] abc = { "something", "abc" };
            return Json(abc);
        }

        public JsonResult newFunction()
        {
            /*var list = dal.userlogins.ToList();
            var json = JsonConvert.SerializeObject(list);*/
            String[] abc = { "something", "abc" };
            return Json(abc);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
