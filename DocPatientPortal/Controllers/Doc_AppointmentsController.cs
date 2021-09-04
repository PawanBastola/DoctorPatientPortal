using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocPatientPortal.Models;
using DocPatientPortal.Models.ViewModel;

namespace DocPatientPortal.Controllers
{
    public class Doc_AppointmentsController : Controller
    {
        DataContext dal = new DataContext();
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Logged") == "true")
            {
                


                //getting did from login session
                String username = JsonConvert.DeserializeObject<UserLogin>(HttpContext.Session.GetString("User")).username;
                //now we can bring the doc id
                List<Doctor_Details> doc = dal.Doctors.Where(x=>x.d_username.Equals(username)).ToList();

                //list of todays appointment
                List<Appointment> appointmentlist = dal.appointmentss.Where(x => x.doc_id.Equals(doc[0].d_id)).Where(y=>y.adate.Equals(DateTime.Now.Date)).ToList<Appointment>();

                List<ViewModelAppointment> viewmodellist = appointmentlist.Select(appointmentx => new ViewModelAppointment()
                {
                    aid=appointmentx.aid,
                    doc_id= appointmentx.doc_id,
                    uid = appointmentx.uid,
                    adate = appointmentx.adate,
                    patient_name = dal.Patients.Where(x=>x.p_id==appointmentx.uid).First().p_fullname
                }).ToList();

                
                                

                
                //getting current date
                //DateTime localdate = DateTime.Now;
                ViewBag.Appointment = viewmodellist;

                return View();

            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
       


    }
}
