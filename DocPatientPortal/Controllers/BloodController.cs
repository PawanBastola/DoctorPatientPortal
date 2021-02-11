using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocPatientPortal.Models;

namespace DocPatientPortal.Controllers
{
    public class BloodController : Controller
    {
        //create datacontext object
        DataContext dal = new DataContext();

        public IActionResult Index()
        {
            ViewBag.message = "hello this is a blood";
            selectUsers();
            return View();
        }

        #region INSERT

        [HttpPost]
        public IActionResult addUsers(User user)
        {
            try
            {
                /*DataContext dal = new DataContext();*/
                dal.Users.Add(user);
                dal.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return RedirectToAction("Index","Blood");

        }
        #endregion
        #region UPDATE
        public IActionResult Update(int pid)
        {
            var data = dal.Users.Find(pid);
            ViewBag.Data = data;
            //update ko lagi euta form banaune data varine.
            //index ko text box ma value = @ViewBag.Data.pname
            //index ko text box ma value = @ViewBag.Data.paddress
            //index ko text box ma value = @ViewBag.Data.pblood
            return View();//Update vanne view banaune.
        }
        #endregion
        #region UpdateData

        [HttpPost]
        public IActionResult UpdateData(User users)
        {
            dal.Users.Update(users);
            dal.SaveChanges();
            return Redirect("/Blood/Index");
        }
        #endregion
        #region DELETE
        public IActionResult Delete(int pid)
        {
            var data = dal.Users.Find(pid);
            dal.Users.Remove(data);
            dal.SaveChanges();
            return RedirectToAction("Index","Blood");
        }
        #endregion
        #region Select

        public IActionResult selectUsers()
        {
            try
            {

                //bring the data of search BOX and query from LINQ.=>  jquery ...//datatable.
                var data = dal.Users.ToList();
                //var result = data.Where(x=>x.pname.Contains("A"));
                ViewBag.Data = data;



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return Redirect("/Blood/Index");
        }
        #endregion






    }
}
