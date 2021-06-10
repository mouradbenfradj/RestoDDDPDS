using RestoDDD.Application.Entities;
using RestoDDD.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestoDDD.Presentation.Areas.Administration.Controllers
{
    public class AdminCuisineController : Controller
    {
        public readonly ICuisineAppService _CuisineAppService;
        public AdminCuisineController(ICuisineAppService CuisineAppService)
        {
            _CuisineAppService = CuisineAppService;
        }
        //
        // GET: /Administration/AdminCuisine/
        public ActionResult Index()
        {
            return View(_CuisineAppService.GetAll());
        }

        //
        // GET: /Administration/AdminCuisine/Details/5
        public ActionResult Details(int id)
        {
            return View(_CuisineAppService.GetById(id));
        }

        //
        // GET: /Administration/AdminCuisine/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Administration/AdminCuisine/Create
        [HttpPost]
        public ActionResult Create(Cuisine_DTO obj)
        {
            try
            {

                // TODO: Add insert logic here
                _CuisineAppService.Add(obj);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Administration/AdminCuisine/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_CuisineAppService.GetById(id));
        }

        //
        // POST: /Administration/AdminCuisine/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Cuisine_DTO obj)
        {
            try
            {
                obj.CuisineID = id;
                // TODO: Add update logic here
                _CuisineAppService.Update(obj);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Administration/AdminCuisine/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_CuisineAppService.GetById(id));
        }

        //
        // POST: /Administration/AdminCuisine/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Cuisine_DTO obj)
        {
            try
            {
                // TODO: Add delete logic here
                obj.CuisineID = id;
                _CuisineAppService.Remove(obj);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
