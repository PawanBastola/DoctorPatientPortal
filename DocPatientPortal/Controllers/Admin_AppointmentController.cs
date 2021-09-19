using DocPatientPortal.Models;
using DocPatientPortal.Models.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocPatientPortal.Controllers
{
    public class Admin_AppointmentController : Controller
    {
        DataContext dal = new DataContext();
        public IActionResult View_Appointment()
        {
            if (HttpContext.Session.GetString("Logged") == "true")
            {
                List<Appointment> appointmentlist = dal.appointmentss.Where(y => y.adate.Equals(DateTime.Now.Date)).Where(z => z.status.Equals("Pending")).ToList<Appointment>();

                List<ViewModelAppointment> selectedViewModel = appointmentlist.Select(appointmentx => new ViewModelAppointment()
                {
                    aid = appointmentx.aid,
                    doc_id = appointmentx.doc_id,
                    uid = appointmentx.uid,
                    adate = appointmentx.adate,
                    patient_name = dal.Patients.Where(x => x.p_id == appointmentx.uid).First().p_fullname,
                    doctor_name = dal.Doctors.Where(x => x.d_id == appointmentx.doc_id).First().d_full_name



                }).ToList();

                ViewBag.allappointmenttoday = selectedViewModel;

                return View();

            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}
