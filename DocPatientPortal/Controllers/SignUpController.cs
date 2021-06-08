using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocPatientPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace DocPatientPortal.Controllers
{
    public class SignUpController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public SignUpController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        #region uploadimage functions
        
        public async Task<string> UploadImage(string folderpath, IFormFile d_certificate)
        {
            folderpath += Guid.NewGuid().ToString() + "_" + d_certificate.FileName;
            string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folderpath);
            await d_certificate.CopyToAsync(new FileStream(serverFolder, FileMode.Create));
            return "/" + folderpath;
        }
        #endregion

        DataContext dal = new DataContext();
        public IActionResult Index()
        {
            return View();
        }

        //checking if username is already created
        [HttpPost]
        public bool exists(DoctorSignupViewModel viewmodel)
        {
            var user = dal.userlogins.Where(x => x.username.Equals(viewmodel.username)).ToList();
            int count = user.Count();
            bool exist = true;
            if (count >= 1)
            {
                exist = true;
            }
            else
            {
                exist = false;
            }

            return exist;
        }

        [HttpPost]
        public async Task<IActionResult> Doctor_register(DoctorSignupViewModel viewmodel, IFormFile d_certificate)
        {

            var user = dal.userlogins.Where(x => x.username.Equals(viewmodel.username)).ToList();
            int count = user.Count();
            

          

                string folder = "image/certificate/";
                viewmodel.d_certificate = await UploadImage(folder, d_certificate);
                

          
            UserLogin login = new UserLogin()
            {

                username = viewmodel.username,
                password = viewmodel.password,
                role = "doctor",
                status = "pending"
            };

            Doctor_Details doctors = new Doctor_Details()
            {

                d_full_name = viewmodel.d_full_name,
                d_dob = viewmodel.d_dob,
                d_contact = viewmodel.d_contact,
                d_email = viewmodel.d_email,
                d_certificate = viewmodel.d_certificate,
                d_state = viewmodel.d_state,
                d_city = viewmodel.d_city,
                d_full_address = viewmodel.d_full_address,
                d_gender = viewmodel.d_gender,
                d_blood_group = viewmodel.d_blood_group,
                d_speciality = viewmodel.d_speciality,
                d_username = viewmodel.username
            };



            dal.userlogins.Add(login);
            dal.Doctors.Add(doctors);
            dal.SaveChanges();


            return RedirectToAction("Register_message", "SignUp");


        }



        public IActionResult Register_message()
        {

            return View();
        }
    }
}
