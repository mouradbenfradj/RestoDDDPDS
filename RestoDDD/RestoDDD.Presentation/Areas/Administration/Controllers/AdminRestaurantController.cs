using RestoDDD.Application.Entities;
using RestoDDD.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestoDDD.Presentation.Areas.Administration.Controllers
{
    public class AdminRestaurantController : Controller
    {
        public readonly IRestaurantAppService _RestaurantAppService;
        public AdminRestaurantController(IRestaurantAppService RestaurantAppService)
        {
            _RestaurantAppService = RestaurantAppService;
        }

        
        //
        // GET: /Administration/AdminRestaurant/
        public ActionResult Index()
        {
            return View(_RestaurantAppService.GetAll());
        }

        //
        // GET: /Administration/AdminRestaurant/Details/5
        public ActionResult Details(int id)
        {
            return View(_RestaurantAppService.GetById(id));
        }

        //
        // GET: /Administration/AdminRestaurant/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Administration/AdminRestaurant/Create
        [HttpPost]
        public ActionResult Create(Restaurant_DTO resto)
        {
           // try
            //{
                // TODO: Add insert logic here
                _RestaurantAppService.Add(resto);
                return RedirectToAction("Index");
           /* }
            catch
            {
                return View();
            }
            * */
        }

        //
        // GET: /Administration/AdminRestaurant/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_RestaurantAppService.GetById(id));
        }

        //
        // POST: /Administration/AdminRestaurant/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Restaurant_DTO resto)
        {
            try
            {
                // TODO: Add update logic here
                resto.RestaurantId = id;
                _RestaurantAppService.Update(resto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Administration/AdminRestaurant/Delete/5
        public ActionResult Delete(int id)
        {

            return View(_RestaurantAppService.GetById(id));
        }

        //
        // POST: /Administration/AdminRestaurant/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Restaurant_DTO resto)
        {
            try
            {
                // TODO: Add delete logic here
                resto.RestaurantId = id;
                _RestaurantAppService.Remove(resto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
