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
            int uid = prescription.p_id;
            Appointment this_appointment = dal.appointmentss.Where(x=>x.uid==uid).ToList().First();
            this_appointment.status = "Appointed";

            dal.appointmentss.Update(this_appointment);
            //checking
            dal.prescriptions.Add(prescription);
            dal.SaveChanges();
            return RedirectToAction("Index","Doc_Appointments");
        }

       


        

    }
}
