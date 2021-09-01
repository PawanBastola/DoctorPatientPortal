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

                var data = dal.Doctors.ToList();
                ViewBag.Data = data;

                return View();
            }
            else
                return RedirectToAction("Index", "Login");

        }


        //overriding the method

        [HttpPost]
        public IActionResult ApptBook(String adate, String doc_spec)
        {
            try
            {

                // List<Unavaibility> absentdate = dal.unavaibilities.Where(x => x.absent_date.Equals(adate)).ToList<Unavaibility>();
                //List<Doctor_Details> available_doctors = dal.Doctors.Where(s=>s.d_speciality.Equals(doc_spec)).Where(x=>absentdate.All(z=>z.did!=x.d_id)).ToList<Doctor_Details>();

                //absent doctor id in choosen date
                List<Unavailability> udatelist = dal.unavaibilities.Where(x=>x.absent_date.Contains(adate)).ToList<Unavailability>();
                //speciality filter of doctor
                List<Doctor_Details> available_doctors = dal.Doctors.Where(x => x.d_speciality.Equals(doc_spec)).ToList<Doctor_Details>();
                //date filter of doctor
                List<Doctor_Details> date_filters = available_doctors.Where(x => udatelist.All(y => y.did != x.d_id)).ToList<Doctor_Details>();
                //eureka! eureka!! at 1:06 am morning

                ViewBag.Data = date_filters;

                return View();
            }
            catch (Exception)
            {

                throw;
            }

        }

        /* var data = from cols in dal.unavaibilities
                    from c in dal.Doctors
                    where cols.absent_date != adate && c.d_speciality == doc_spec
                    select new
                    {
                        d_id = c.d_id,
                        d_full_name=c.d_full_name,
                        d_speciality = c.d_speciality,
                        d_city = c.d_city
                    };*/









        //here we are going to use the book [Button] residing on [ApptBook View] to insert appintment details in appointment table.
        //which have aid(Key), uid, doc_id, adate(DateTime), atime(DateTime)

        //quering for available doctor
        //To Be Continue...till now 2078/05/13


        //-------------------------------WORKING HERE-----------------------------------------------------------------------




        public void Check(String doc_spec, String adate)// multiple constraints query is passed eg. Doc-speciality, Date
        {
            //ya date aayo
            this.date = adate;




        }


        //not working
        public IActionResult Insert(int did, DateTime adate)
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
                doc_id = did

            };

            dal.appointmentss.Add(data);
            dal.SaveChanges();

            return RedirectToAction("ApptView", "Appointment");

        }
        public IActionResult ApptView()
        {

            //checking if session is set

            if (HttpContext.Session.GetString("Logged") == "true")
            {


                try
                {
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
