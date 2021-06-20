using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CommercialAutomation.Models.Classes;

namespace CommercialAutomation.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        Context c = new Context();
        public ActionResult Index()
        {
            var DepartmenValues = c.Departments.Where(x => x.Status == true).ToList();
            return View(DepartmenValues);
        }
        [HttpGet]
        public ActionResult AddDepartment()
        {
            return View();

        }
        [HttpPost]
        public ActionResult AddDepartment(Department d)
        {
            c.Departments.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult DeleteDepartment(int id)
        {
            var DeleteDep = c.Departments.Find(id);
            DeleteDep.Status = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetDepartment(int id)
        {
            var UpdateDep = c.Departments.Find(id);
            return View("GetDepartment", UpdateDep);


        }
        public ActionResult UpdateDepartment(Department dp)
        {
            var UpDep = c.Departments.Find(dp.DepartmentID);
            UpDep.DepartmentName = dp.DepartmentName;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}