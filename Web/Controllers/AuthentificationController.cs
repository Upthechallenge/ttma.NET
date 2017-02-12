
using domain.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace GUI.Controllers
{
    public class AuthentificationController : Controller

    {
        IAuthentificationService ause;
        public AuthentificationController(IAuthentificationService ause)
        {
            this.ause = ause;
        }
        public AuthentificationController() { }
        [ValidateAntiForgeryToken]
        private IEnumerable<Claim> LoadRoles(string login, string password)
        {
            IAuthentificationService ause = new AuthentificationService();

            yield return new Claim(ClaimTypes.Role, ause.getRoleFromLoginetPassword(login, password));
            yield return new Claim(ClaimTypes.Name, ause.getNameFromLoginAndPasswod(login, password));
            yield return new Claim(ClaimTypes.Email, ause.Authentification(login, password).e_mail);
            yield return new Claim(ClaimTypes.PrimarySid, ause.Authentification(login, password).id.ToString());

            // yield return new Claim(ClaimTypes.Name, ause.Authentification(login, password).name);

        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(staff model, string returnUrl)
        {
            IAuthentificationService ause = new AuthentificationService();

            staff em = new staff();

            model = ause.Authentification(model.login, model.mdp);
            ViewBag.ReturnUrl = returnUrl;

            if (!ModelState.IsValid)
            {
                return View(model);
            }


            if (model != null)
            {
                //  if ((model.Username == "ramzi") && (model.Password) == "ramzi") {
                // L'authentification est réussie, 
                // injecter l'identifiant utilisateur dans le cookie d'authentification :
                var userClaims = new List<Claim>();
                // Identifiant utilisateur :
                userClaims.Add(new Claim(ClaimTypes.NameIdentifier, model.login));
                // Rôles utilisateur :
                userClaims.AddRange(LoadRoles((model.login), (model.mdp)));
                var claimsIdentity = new ClaimsIdentity(userClaims, DefaultAuthenticationTypes.ApplicationCookie);
                var ctx = Request.GetOwinContext();
                var authenticationManager = ctx.Authentication;
                authenticationManager.SignIn(claimsIdentity);
                // Rediriger vers l'URL d'origine :
                if (Url.IsLocalUrl(ViewBag.ReturnUrl))
                    return Redirect(ViewBag.ReturnUrl);
                // Par défaut, rediriger vers la page d'accueil :
                em = model;


                if (model.function == "user")
                {

                    return RedirectToAction("Index", "Home");
                }

                if (model.function == "staff")
                {

                    return RedirectToAction("IndexBack", "Home");
                }

                if (model.function == "doctor")
                {

                    return RedirectToAction("Patientrequest", "Consultation");
                }

                else return null;

            }
            else
            {
                ModelState.AddModelError(string.Empty, "Le nom d'utilisateur ou le mot de passe est incorrect.");
                return View(model);
            }
        }
        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }
        //
        // POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            return RedirectToAction("Index", "Home");
        }

        // GET: Conge/Create
        public ActionResult Register()
        {
            return View();
        }

        // POST: Conge/Create
        [HttpPost]
        public ActionResult Register(staff h)
        {
            if (ModelState.IsValid)
            {
                ause.CreateUser(h);

                return RedirectToAction("Login");
            }


            else

                return View();
        }
    }
}