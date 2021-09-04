using DocPatientPortal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocPatientPortal.Controllers
{
    public class ProfileController : Controller
    {
        //create datacontext object
        DataContext dal = new DataContext();


        public IActionResult Index(int doc_id)
        {

            if (HttpContext.Session.GetString("Logged") == "true")
            {
                //String username = JsonConvert.DeserializeObject<UserLogin>(HttpContext.Session.GetString("User")).username;
                //int did = dal.Doctors.Where(x => x.d_username.Equals(username)).First().d_id;
            var docData = dal.Doctors.Find(doc_id);
            ViewBag.ViewProfile = docData;
            return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public IActionResult PatientProfile(int pat_id)
        {
            if (HttpContext.Session.GetString("Logged") == "true")
            {
                var patientData = dal.Patients.Find(pat_id);
                ViewBag.Patient = patientData;

                var diagnoseddata = dal.prescriptions.Where(x=>x.p_id.Equals(pat_id)).ToList(); 
                ViewBag.Prescription = diagnoseddata;
                
            return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }



       

        

        

    }
}