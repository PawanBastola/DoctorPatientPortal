using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocPatientPortal.Models;
using Microsoft.AspNetCore.Http;

namespace DocPatientPortal.Controllers
{
    public class OffdayController : Controller
    {
        DataContext dal = new DataContext();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Addoffday(String absent_date)
        {
            string username = JsonConvert.DeserializeObject<UserLogin>(HttpContext.Session.GetString("User")).username;
            List<Doctor_Details> doclist = dal.Doctors.Where(x=>x.d_username.Contains(username)).ToList();
            int did = doclist[0].d_id;

            Unavailability data = new Unavailability()
            {
                did = did,
                absent_date = absent_date

            };
            dal.unavaibilities.Add(data);
            dal.SaveChanges();
            return RedirectToAction("Index","Offday");
        }
    }
}
