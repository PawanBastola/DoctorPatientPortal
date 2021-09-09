using DocPatientPortal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocPatientPortal.Controllers
{
    public class SpecialityController : Controller
    {
        DataContext dal = new DataContext();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(Speciality speciality)
        {
            dal.specialities.Add(speciality);
            dal.SaveChanges();
            
            return RedirectToAction("Index","Speciality");
        }
    }
}
