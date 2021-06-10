using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestoDDD.Presentation.Areas.Administration.Controllers
{
    public class AdminMenuController : Controller
    {
        //
        // GET: /Administration/AdminMenu/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Administration/AdminMenu/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Administration/AdminMenu/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Administration/AdminMenu/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Administration/AdminMenu/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Administration/AdminMenu/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Administration/AdminMenu/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Administration/AdminMenu/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
