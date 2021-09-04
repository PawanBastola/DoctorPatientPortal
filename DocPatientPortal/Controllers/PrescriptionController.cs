using DocPatientPortal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocPatientPortal.Controllers
{
    public class PrescriptionController : Controller
    {
        DataContext dal = new DataContext();
        public IActionResult Index(int p_id)
        {
            ViewBag.p_id = p_id;
            return View();
        }

        public IActionResult AddPrescription(Prescription prescription)
        {
            dal.prescriptions.Add(prescription);
            dal.SaveChanges();
            return RedirectToAction("Index","Doc_Appointments");
        }


        

    }
}
