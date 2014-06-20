using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployMvcPresentation.EmployeeDataAccessService;
using EmployMvcPresentation.Models;

namespace EmployMvcPresentation.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeDataAccessService.IEmployeeDataAccess Repository = new EmployeeDataAccessClient();

        //
        // GET: /Employee/

        public ActionResult Index()
        {
            return View(Repository.Fetch().ToViewModels());
        }

        //
        // GET: /Employee/Details/5

        public ActionResult Details(int id = 0)
        {
            EmployeeViewModel employee = Repository.FetchById(id).ToViewModel();
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        //
        // GET: /Employee/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Employee/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployMvcPresentation.Models.EmployeeViewModel employee)
        {
            if (ModelState.IsValid)
            {
                Repository.Add(employee.ToDataContract());
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        //
        // GET: /Employee/Edit/5

        public ActionResult Edit(int id = 0)
        {
            EmployMvcPresentation.Models.EmployeeViewModel employee = Repository.FetchById(id).ToViewModel();
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        //
        // POST: /Employee/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmployeeViewModel employee)
        {
            if (ModelState.IsValid)
            {
                Repository.Update(employee.ToDataContract());
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        //
        // GET: /Employee/Delete/5

        public ActionResult Delete(int id = 0)
        {
            EmployeeViewModel employee = Repository.FetchById(id).ToViewModel();
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        //
        // POST: /Employee/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Repository.DeleteById(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            Repository = null;
            base.Dispose(disposing);
        }
    }
}