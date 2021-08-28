using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using DocPatientPortal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using DocPatientPortal.Models.ViewModel;

namespace DocPatientPortal.Controllers
{
    public class AppointmentController : Controller
    {
        DataContext dal = new DataContext();
        String date;

        //apptBook view matrai ho yo.
        public IActionResult ApptBook()
        {

           
            //int user_id = JsonConvert.DeserializeObject<UserLogin>(HttpContext.Session.GetString("User")).uid;///getting from session

            if (HttpContext.Session.GetString("Logged") == "true")
            {
                ViewBag.speciality = new List<String> { "Bone", "Cardiac", "something" };
                SelectAllDoctors();
                return View();
            }
            else
                return RedirectToAction("Index", "Login");
            
        }
        #region SelectCode All Doctors
        public IActionResult SelectAllDoctors()
        {
            try
            {
                //bring the data of search BOX and query from LINQ.=>  jquery ...//datatable.
                var data = dal.Doctors.ToList();
                //var result = data.Where(x=>x.pname.Contains("A"));
                ViewBag.Data = data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return Redirect("/Appointment/ApptBook");
        }

        #endregion

        //here we are going to use the book [Button] residing on [ApptBook View] to insert appintment details in appointment table.
        //which have aid(Key), uid, doc_id, adate(DateTime), atime(DateTime)

        //quering for available doctor
        //To Be Continue...till now 2078/05/13


        //-------------------------------WORKING HERE-----------------------------------------------------------------------


        
        
        public void Check(String adate)// multiple constraints query is passed eg. Doc-speciality, Date, Time.
        {
            //ya date aayo
            this.date = adate;

           
            
        }


        public IActionResult Insert(int did , DateTime adate)
        {
         
            //appointment
            //patient user
            int uid = JsonConvert.DeserializeObject<UserLogin>(HttpContext.Session.GetString("User")).uid;
            // String sdate = date.ToString("dd/MM/yyyy");
            //DateTime trimmeddate = Convert.ToDateTime(sdate);
            //DateTime adate = Convert.ToDateTime(date);
            
            Appointment data = new Appointment()
            {
                adate = adate,
                uid = uid,
                doc_id=did

            };

            dal.appointmentss.Add(data);
            dal.SaveChanges();

            return RedirectToAction("ApptView", "Appointment");

        }
        public IActionResult ApptView()
        {
           /* if (HttpContext.Session.GetString("Logged")=="true")
            {

            }
            else
            {
                return RedirectToAction("Index","Login");
            }*/
            //checking if session is set

            if (HttpContext.Session.GetString("Logged")=="true")
            {
                

                try{
                    //id from session
                    int uid = JsonConvert.DeserializeObject<UserLogin>(HttpContext.Session.GetString("User")).uid;

                    //list of appointment of user
                    List<Appointment> appointmentList = dal.appointmentss.Where(x => x.uid.Equals(uid)).ToList<Appointment>();
                    List<Doctor_Details> doctorList = dal.Doctors.ToList<Doctor_Details>();
                    ViewBag.appointments = appointmentList;
                    ViewBag.doctorList = doctorList;
                }
                catch (Exception error)
                {
                    Console.WriteLine(error);
                }

                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
            //getting user id from session
           
           
        }
        public IActionResult ApptCancel(int aid)
        {
            Appointment thisappointment = dal.appointmentss.Find(aid);
            dal.Remove(thisappointment);
            dal.SaveChanges();
            return RedirectToAction("ApptView", "Appointment");
        }

    }
}
