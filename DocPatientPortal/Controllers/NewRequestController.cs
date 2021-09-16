using DocPatientPortal.Models;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocPatientPortal.Controllers
{
    public class NewRequestController : Controller
    {
        DataContext dal = new DataContext();

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Logged") == "true")
            {
                selectdoctor();
                return View();

            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        #region selectdoctor
        public void selectdoctor()
        {
            try
            {
                var data = dal.Doctors.ToList();
                ViewBag.doctors = data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        #endregion

        public IActionResult ViewRequest(int id)
        {
            if (HttpContext.Session.GetString("Logged") == "true")
            {
                var find_doctor = dal.Doctors.Find(id);

                ViewBag.this_doctor = find_doctor;

                return View();

            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public IActionResult Approve(String username)
        {
            UserLogin logindata = dal.userlogins.Where(x => x.username.Equals(username)).SingleOrDefault();

            string email = dal.Doctors.Where(x => x.d_username.Equals(logindata.username)).SingleOrDefault().d_email;


            //mailing
            MimeMessage message = new MimeMessage();
            SmtpClient client = new SmtpClient();
            //sender
            message.From.Add(new MailboxAddress("DoctorPatientPortal", "doctorpatientappointment.portal@gmail.com"));
            //receiver
            message.To.Add(MailboxAddress.Parse(email));
            //subject of message
            message.Subject = "Account Information";
            //creating message
            message.Body = new TextPart("plain")
            {
                Text = "your id has been activated sucessfully! Please Login "
            };




            //connect with smtp of gmail port:465
            client.Connect("smtp.gmail.com", 465, true);
            //email-id , password
            client.Authenticate("doctorpatientappointment.portal@gmail.com", "99886600779922778800");
            //send mail
            client.Send(message);
            //mail code end
            //mailing

            logindata.status = "Active";
            dal.userlogins.Update(logindata);
            dal.SaveChanges();

            return RedirectToAction("Index", "NewRequest");
        }
        public IActionResult Deny(String username)
        {
            List<UserLogin> user = dal.userlogins.Where(x => x.username.Equals(username)).ToList<UserLogin>();

            UserLogin logindata = user[0];

            logindata.status = "Suspended";
            dal.userlogins.Update(logindata);
            dal.SaveChanges();





            return RedirectToAction("Index", "NewRequest");
        }

    }
}
