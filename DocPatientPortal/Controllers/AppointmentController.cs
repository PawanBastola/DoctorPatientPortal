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

namespace DocPatientPortal.Controllers
{
    public class AppointmentController : Controller
    {
        DataContext dal = new DataContext();


        //apptBook view matrai ho yo.
        public IActionResult ApptBook()
        {
            ViewBag.speciality = new List<String> { "Bone", "Cardiac", "something" };

            selectUsers();
            /*if (HttpContext.Session.GetString("Logged") == "true")
                return View();
            else
                return RedirectToAction("Index","Login");*/
            return View();
        }


        #region SelectCode
        public IActionResult selectUsers()
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
        //To Be Continue...
        public IActionResult Check(String doc_spec, DateTime date, DateTime time)// multiple constraints query is passed eg. Doc-speciality, Date, Time.
        {

            try
            {
                /*DataContext dal = new DataContext();*/
                var dataset = dal.Doctors.Find(doc_spec, date, time);
                ViewBag.available_doc = dataset;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


            return RedirectToAction("ApptBook");
        }



        public IActionResult ApptView()
        {
            return View();
        }
        public IActionResult ApptCancel()
        {
            return View();
        }

    }
}
