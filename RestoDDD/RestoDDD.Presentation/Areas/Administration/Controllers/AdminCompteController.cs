using RestoDDD.Application.Entities;
using RestoDDD.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestoDDD.Presentation.Areas.Administration.Controllers
{
    public class AdminCompteController : Controller
    {
        public readonly ICompteAppService _CompteAppService;
        public AdminCompteController(ICompteAppService CompteAppService)
        {
            _CompteAppService = CompteAppService;
        }
        //
        // GET: /Administration/AdminCompte/
        public ActionResult Index()
        {
            return View(_CompteAppService.GetAll());
        }

        //
        // GET: /Administration/AdminCompte/Details/5
        public ActionResult Details(int id)
        {
            return View(_CompteAppService.GetById(id));
        }

        //
        // GET: /Administration/AdminCompte/Create
        

        //
        // GET: /Administration/AdminCompte/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_CompteAppService.GetById(id));
        }

        //
        // POST: /Administration/AdminCompte/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Compte_DTO obj)
        {
            try
            {
                obj.CompteId = id;
                // TODO: Add update logic here
                _CompteAppService.Update(obj);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Administration/AdminCompte/Delete/5
        public ActionResult Delete(int id)
        {
            
            return View(_CompteAppService.GetById(id));
        }

        //
        // POST: /Administration/AdminCompte/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Compte_DTO obj)
        {
            try
            {
                obj.CompteId = id;
                // TODO: Add delete logic here
                _CompteAppService.Remove(obj);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
