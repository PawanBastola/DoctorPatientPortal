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
        

        public async Task<string> UploadImage(string folderpath, IFormFile file)
        {
            folderpath += Guid.NewGuid().ToString() + "_" + file.FileName;
            string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folderpath);
            await file.CopyToAsync(new FileStream(serverFolder, FileMode.Create));
            return "/" + folderpath;
        }
        

        DataContext dal = new DataContext();
        public IActionResult Index()
        {
            ViewBag.speciality = dal.specialities.ToList();
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

        //doctor signup
        [HttpPost]
        public async Task<IActionResult> Doctor_register(DoctorSignupViewModel viewmodel)
        {
            string folder = "image/certificate/";

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
                d_certificate = await UploadImage(folder, viewmodel.d_certificate),
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


       //patient signup
        
        [HttpPost]
        public async Task<IActionResult> Patient_register(Patient_Details patient, string password, string username, IFormFile photo)
        {
            //here we haven't used viewmodel for user and patient_details model
            //instead we have taken password, username, file argument in this function
            string folder = "image/profile_pic/";

            UserLogin login_patient = new UserLogin()
            {

                username = username,
                password = password,
                role = "patient",
                status = "Active"
            };

            Patient_Details patient_obj = new Patient_Details()
            {
                p_fullname = patient.p_fullname,
                p_dob = patient.p_dob,
                p_contact = patient.p_contact,
                p_email = patient.p_email,
                p_photo = await UploadImage(folder, photo),//note: p_photo should be of (S)tring type not (s)tring type. if string is used the file name wont be trimmed.
                p_state = patient.p_state,
                p_city = patient.p_city,
                p_gender = patient.p_gender,
                p_fulladdress = patient.p_fullname,
                p_blood = patient.p_blood,
                p_username = username


            };

            dal.userlogins.Add(login_patient);
            dal.Patients.Add(patient_obj);
            dal.SaveChanges();
            return RedirectToAction("Index", "Login");
        }

        public IActionResult Register_message()
        {

            return View();
        }
    }
}
