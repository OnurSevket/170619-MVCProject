using MVCEmployeeManagement.EF;
using MVCEmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEmployeeManagement.Controllers
{
    public class DepartmentController : Controller
    {
        DataContext _db = new DataContext();
        // GET: Department
        public ActionResult Index()
        {
            List<Department> model = _db.Departments.ToList();

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            //Department model1 = _db.Departments.Find(id);
            Department model = _db.Departments.SingleOrDefault(x => x.ID == id);

            //var modeltest= _db.Departments.Where(x => x.ID == id).Select(x => x.Name);

            //var model3 = (from d in _db.Departments
            //                     where d.ID == id
            //                     select new
            //                     {
            //                         d.ID,
            //                         d.Name
            //                     }
            //                    ).SingleOrDefault();
            if (model != null)
            {
                return View(model);
            }
            else
            {
                return HttpNotFound();
            }
        }

        public ActionResult EditConfirmed(Department department)
        {
            Department dept = _db.Departments.Find(department.ID);

            if (dept != null)
            {
                dept.Name = department.Name;
                dept.Description = department.Description;

                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return HttpNotFound();
            }


            
        }
    }
}