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

        /// <summary>
        /// Show list of authors connectiing to the views folder
        /// </summary>
        /// <param name="id">int as ID</param>
        /// <returns>List of class rendered to the list page</returns>
        //GET Class/List
        public ActionResult List()
        {

            ClassesDataController controller = new ClassesDataController();
            IEnumerable<Class> Classes = controller.ListClasses();


            return View(Classes);
        }

        /// <summary>
        /// Show particluar selected class details connecting to the views folder
        /// </summary>
        /// <param name="id">int as ID</param>
        /// <returns>class detials of that selected class</returns>
        ///  //GET Class/Show/{id}
        public ActionResult Show(int id)
        {

            ClassesDataController controller = new ClassesDataController();
            Class NewClass = controller.FindClass(id);

            return View(NewClass);
        }





        [HttpPost]
        // POST Class/AddSecondaryKey
        public ActionResult AddSecondaryKey()
        {
            ClassesDataController controller = new ClassesDataController();
            controller.AddForeignKey();

            return RedirectToAction("List");

          
        }
    }
}