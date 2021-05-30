using DocPatientPortal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocPatientPortal.Controllers
{
    public class NewRequestController : Controller
    {
        DataContext dal = new DataContext();

        public IActionResult Index()
        {
            selectdoctor();
            return View();
        }

        #region selectdoctor
        public void selectdoctor()
        {
            try
            {
                var data = dal.Doctors.ToList();
                ViewBag.doctors = data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        #endregion


        public IActionResult ViewRequest(int id)
        {
            var find_doctor = dal.Doctors.Find(id);
            ViewBag.this_doctor = find_doctor;
            return View();
        }
        public IActionResult Approve(String abc)
        {
            return RedirectToAction("Index","NewRequest");
        }
        public IActionResult Deny(String abc)
        {
            return RedirectToAction("Index", "NewRequest");
        }

    }
}
