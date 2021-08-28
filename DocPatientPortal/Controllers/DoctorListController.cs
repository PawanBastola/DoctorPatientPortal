using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocPatientPortal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DocPatientPortal.Controllers
{
    public class DoctorListController : Controller
    {
        DataContext dal = new DataContext();
        public IActionResult Index()
        {
            ViewBag.Doctors = dal.Doctors.ToList();
            return View();

           
           
        }
    }
}
