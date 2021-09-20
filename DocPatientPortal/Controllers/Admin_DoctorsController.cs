using DocPatientPortal.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace DocPatientPortal.Controllers
{
    public class Admin_DoctorsController : Controller
    {
        DataContext dal = new DataContext();
        public IActionResult View_Doctor()
        {
            if (HttpContext.Session.GetString("Logged") == "true")
            {
                var doc_active_list = dal.userlogins.Where(x => x.role == "doctor").Where(x => x.status == "Active");
                var doctorlist = dal.Doctors.ToList();

                //all active doctors
                var activedoctors = doctorlist.Where(x => doc_active_list.All(y => y.username == x.d_username)).ToList();
                //putting value in viewbag
                ViewBag.doctorlist = activedoctors;
                return View();

            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }


        //view doctor action.
        //delete doctor action.
        public IActionResult deleteDoctor(string d_username)
        {
            Doctor_Details doc = dal.Doctors.Where(x => x.d_username == d_username).FirstOrDefault();
            UserLogin u_doc = dal.userlogins.Where(x => x.username == d_username).FirstOrDefault();
            dal.Doctors.Remove(doc);
            dal.userlogins.Remove(u_doc);
            dal.SaveChanges();
            return RedirectToAction("View_Doctor", "Admin_Doctors");
        }
        //gotoupdate doctor action.
        public IActionResult gotoUpdate(string d_username)
        {
            var thisdoctor = dal.Doctors.Where(x => x.d_username == d_username).FirstOrDefault();
            


            //speciality for dropdown
            var spec = dal.specialities.ToList();
            //viewbag
            ViewBag.speciality = spec;
            ViewBag.thisdoctor = thisdoctor;
            return View();
        }

        //Update_Doctor
        private readonly IWebHostEnvironment _webHostEnvironment;



        /* public async Task<string> UploadImage(string folderpath, IFormFile file)
         {
             folderpath += Guid.NewGuid().ToString() + "_" + file.FileName;
             string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folderpath);
             await file.CopyToAsync(new FileStream(serverFolder, FileMode.Create));
             return "/" + folderpath;
         }*/
        [HttpPost]
        public IActionResult Update_Doctor(DoctorSignupViewModel thisdoctor, string d_certificate, int id)
        {

            //signupcontroller instantiation for using upload function
           // SignUpController abc = new SignUpController(_webHostEnvironment);
            Doctor_Details doctor = new Doctor_Details()
            {
                d_dob =thisdoctor.d_dob,
                d_email=thisdoctor.d_email,
                d_city= thisdoctor.d_city,
                d_contact = thisdoctor.d_contact,
                d_full_address  = thisdoctor.d_full_address,
                d_full_name = thisdoctor.d_full_name,
                d_state =thisdoctor.d_state,
                d_blood_group = thisdoctor.d_blood_group,
                d_certificate = d_certificate,
                d_gender = thisdoctor.d_gender,
                d_speciality = thisdoctor.d_speciality,
                d_username=thisdoctor.username,
                d_id = id
                
                

               // d_certificate = await abc.UploadImage("image/certificate/", thisdoctor.d_certificate),//importing upload image function from signup controller
                
            };
            dal.Doctors.Update(doctor);
            dal.SaveChanges();

            return RedirectToAction("View_Doctor", "Admin_Doctors");

        }

    }
}
