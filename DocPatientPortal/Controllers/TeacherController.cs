using DocPatientPortal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocPatientPortal.Controllers
{
    public class TeacherController : Controller
    {
        DataContext dal = new DataContext();
        public IActionResult Index()
        {
            return View();
        }

        #region insert code

        public IActionResult Insert(Teacher_Table t)
        {
            int t_id = InsertTeacher(t);//id aayo main table bata
            String[] mystringarray = { "primary", "secondary", "higher-secondary" };//array ma halne data [hard coded]
            List<Lvl_Table> list_lvl = new List<Lvl_Table>();

            try
            {

                foreach (var item in mystringarray)
                {
                    list_lvl.Add(new Lvl_Table(t_id, item));
                    dal.levels.Add(new Lvl_Table(t_id, item));
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            dal.SaveChanges();
            return RedirectToAction("Index", "Teacher");
        }
        #endregion

        /*public void Insert()
        {
            int id = 23;

            Teacher_Table teacher = new Teacher_Table()
            {
                
                id= 23,
                email ="pawan",
                name = "pawan"

            };
            dal.teachers.Add(teacher);
            dal.SaveChanges();

            List<Lvl_Table> list_level = new List<Lvl_Table>();
            list_level.Add(new Lvl_Table(id,"primary"));
            list_level.Add(new Lvl_Table(id,"secondary"));
            list_level.Add(new Lvl_Table(id,"higher"));
            list_level.Add(new Lvl_Table(id,"highest"));

            try
            {
            foreach (var item in list_level)
            {
            dal.levels.Add(item);
            }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

            dal.SaveChanges();
        }*/

        //function to insert into main table and return id
        public int InsertTeacher(Teacher_Table t)
        {
            int tid = 0;
            String email_temp = t.email;



            dal.teachers.Add(t);
            dal.SaveChanges();

            var teacher_temp = dal.teachers.Where(x => x.email.Equals(email_temp)).ToList();
            tid = teacher_temp[0].id;

            return tid;
        }
    }
}
