using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DocPatientPortal.Models;

namespace DocPatientPortal.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Heading = "Doctors Available currently";
            List<Doctors> docList = new List<Doctors>()
             {
                 new Doctors(){name="pawan", speciality="Bone"},
                 new Doctors(){name = "ranjan", speciality = "Muscles"}
             };
            

            ViewBag.DoctorIdentity = docList;
            return View();
            
        }
    }
}