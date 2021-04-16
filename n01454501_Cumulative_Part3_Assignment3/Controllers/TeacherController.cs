using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using n01454501_Cumulative_Part2_Assignment4.Models; ///using teachers models field as a reference
using System.Diagnostics;  // tool used for debugging


namespace n01454501_Cumulative_Part2_Assignment4.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult Index()
        {
            return View();
        }

        //GET: Teacher/List
        public ActionResult List(string Searchkey = null)
        {
            Debug.WriteLine("The Search key the is inputted is ");
            Debug.WriteLine(Searchkey);
            // get accesss from the Teachers dataController
            TeacherDataController controller = new TeacherDataController();
            IEnumerable<Teacher> Teachers = controller.ListTeachers(Searchkey);
            return View(Teachers);
        }

        //GET: Teacher/Show/{id}
        public ActionResult Show(int id)
        {// get accesss from the Teachers dataController
            TeacherDataController controller = new TeacherDataController();
            Teacher NewTeacher = controller.FindTeacher(id);

            return View(NewTeacher);
        }

        //GET: Teacher/DeleteConfirm/{id}
        public ActionResult DeleteConfirm(int id)
        {// get accesss from the Teachers dataController
            TeacherDataController controller = new TeacherDataController();
            Teacher NewTeacher = controller.FindTeacher(id);
           
            return View(NewTeacher);
        }


        //GET: Teacher/Delete/{id}
        public ActionResult Delete(int id)
        {// get accesss from the Teachers dataController
            TeacherDataController controller = new TeacherDataController();
            controller.DeleteTeacher(id);

            return RedirectToAction("List");
        }

        //GET:/Teacher/New

        public ActionResult New()
        {
           //returns it to the new view
            return View();
        }

       


        //POST : /Teacher/Add
        [HttpPost]
        public ActionResult Add( string TeacherFname, string TeacherLname, string EmployeeNumber, DateTime HireDate, decimal Salary )
        {
            //Indentify the inputs are provided from the form
            Teacher NewTeacher = new Teacher();
            NewTeacher.TeacherFname = TeacherFname;
            NewTeacher.TeacherLname = TeacherLname;
            NewTeacher.EmployeeNumber = EmployeeNumber;
            NewTeacher.HireDate = HireDate;
            NewTeacher.Salary = Salary;
            TeacherDataController controller = new TeacherDataController();
            controller.AddTeacher(NewTeacher);
            //redirected the user to the list page once the teacher is added to the database and the list is updated
            return RedirectToAction("List");
        }



    }
}