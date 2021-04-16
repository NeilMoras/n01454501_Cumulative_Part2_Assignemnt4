using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using n01454501_Cumulative_Part2_Assignment4.Models; ///using student models field as a reference
using System.Diagnostics; // tool used for debugging


namespace n01454501_Cumulative_Part2_Assignment4.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        //GET: Student/List
        public ActionResult List(string Searchkey = null)
        {
            Debug.WriteLine("The Search key the is inputted is ");
            Debug.WriteLine(Searchkey);
            // get accesss from the Students dataController
            StudentDataController controller = new StudentDataController();
            IEnumerable<Student> Students = controller.ListStudents(Searchkey);
            return View(Students);
        }


        //GET: Student/Show/{id}
        public ActionResult Show(int id)
        {

            StudentDataController controller = new StudentDataController();
            Student NewStudent = controller.FindStudent(id);
            return View(NewStudent);
        }


        //GET: Student/DeleteConfirm/{id}
        public ActionResult DeleteConfirm(int id)
        {
            StudentDataController controller = new StudentDataController();
            Student NewStudent = controller.FindStudent(id);

            return View(NewStudent);
        }


        //GET: Student/Delete/{id}
        public ActionResult Delete(int id)
        {
            StudentDataController controller = new StudentDataController();
            controller.DeleteStudent(id);

            return RedirectToAction("List");
        }

        //GET:/Student/New

        public ActionResult New()
        {
            return View();
        }


        //POST : /Student/Add
        [HttpPost]
        public ActionResult Add(string StudentFname, string StudentLname, string StudentNumber, DateTime EnrolDate)
        {
            //Indentify the inputs are proivded from the form
            Student NewStudent = new Student();
            NewStudent.StudentFname = StudentFname;
            NewStudent.StudentLname = StudentLname;
            NewStudent.StudentNumber = StudentNumber;
            NewStudent.EnrolDate = EnrolDate;
          
            StudentDataController controller = new StudentDataController();
            controller.AddStudent(NewStudent);

            return RedirectToAction("List");
        }
    }
}