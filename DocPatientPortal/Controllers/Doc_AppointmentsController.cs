﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocPatientPortal.Models;

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

                List<Appointment> appointmentlist = dal.appointmentss.Where(x => x.doc_id.Equals(doc[0].d_id)).Where(y=>y.adate.Equals(DateTime.Now.Date)).ToList<Appointment>();

                //patient details
                #region take a name of patient

                /*List<Patient_Details> patient_Details = dal.Patients.ToList();

                List<Patient_Details> filter_patients = patient_Details.Where(x => appointmentlist.All(y => y.uid.Equals(x.p_id))).ToList();*/
                #endregion

                

                
                //getting current date
                //DateTime localdate = DateTime.Now;
                ViewBag.Appointment = appointmentlist;

                return View();

            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}
