using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocPatientPortal.Models;

namespace DocPatientPortal.Controllers
{
    public class AppointmentController : Controller
    {
        DataContext dal = new DataContext();

        public IActionResult ApptBook()
        {
            selectUsers();
            return View();
        }

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
