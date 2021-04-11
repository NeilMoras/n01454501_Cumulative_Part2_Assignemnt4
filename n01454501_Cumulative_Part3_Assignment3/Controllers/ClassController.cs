using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using n01454501_Cumulative_Part2_Assignment4.Models;

namespace n01454501_Cumulative_Part2_Assignment4.Controllers
{
    public class ClassController : Controller
    {
        // GET: Class
        public ActionResult Index()
        {
            return View();
        }

        //GET Class/List
        public ActionResult List()
        {

            ClassesDataController controller = new ClassesDataController();
            IEnumerable<Class> Classes = controller.ListClasses();


            return View(Classes);
        }
        //GET Class/Show/{id}
        public ActionResult Show(int id)
        {

            ClassesDataController controller = new ClassesDataController();
            Class NewClass = controller.FindClass(id);

            return View(NewClass);
        }
    }
}