using Microsoft.AspNet.Identity;
using RestoDDD.Application.Entities;
using RestoDDD.Application.Interfaces;
using RestoDDD.Presentation.Models;
using System.Collections.Generic;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace RestoDDD.Presentation.Controllers
{
    public class AuthenticationController : Controller
    {
        public readonly ICompteAppService _CompteAppService;
        public AuthenticationController(ICompteAppService CompteAppService)
        {
            _CompteAppService = CompteAppService;
        }
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            var ctx = Request.GetOwinContext();
            var authenticationManager = ctx.Authentication;
            authenticationManager.SignOut();

            // Rediriger vers la page d'accueil :
            return RedirectToAction("Index", "Home");
        }

        [AllowAnonymous]
        
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
    
        public ActionResult Register(Compte_DTO obj)
        {       
                // TODO: Add insert logic here
                _CompteAppService.Add(obj);
                return RedirectToAction("Index");
        }


        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            if (!ValidateUser(model.UserName, model.Password))
            {
                ModelState.AddModelError(string.Empty, "Le nom d'utilisateur ou le mot de passe est incorrect.");
                return View(model);
            }

            // L'authentification est réussie, 
            // injecter les informations utilisateur dans le cookie d'authentification :
            var userClaims = new List<Claim>();
            // Identifiant utilisateur :
            userClaims.Add(new Claim(ClaimTypes.NameIdentifier, model.UserName));
            // Rôles utilisateur :
            userClaims.AddRange(LoadRoles(model.UserName));
            var claimsIdentity = new ClaimsIdentity(userClaims, DefaultAuthenticationTypes.ApplicationCookie);
            var ctx = Request.GetOwinContext();
            var authenticationManager = ctx.Authentication;
            authenticationManager.SignIn(claimsIdentity);

            // Rediriger vers l'URL d'origine :
            if (Url.IsLocalUrl(ViewBag.ReturnUrl))
                return Redirect(ViewBag.ReturnUrl);
            // Par défaut, rediriger vers la page d'accueil :
            return RedirectToAction("Index");
        }

        private IEnumerable<Claim> LoadRoles(string login)
        {
            // TODO : Charger ici les rôles de l'utilisateur...

            // Pour ce tutoriel, je considère que l'utilisateur a les rôles "Contributeur" et "Modérateur" :
            yield return new Claim(ClaimTypes.Role, "Administrateur");
        }

        private bool ValidateUser(string login, string password)
        {
           
            return login == password;
        }
    }
}