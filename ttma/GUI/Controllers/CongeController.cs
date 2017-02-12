using Data.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GUI.Controllers
{
    public class CongeController : Controller
    {
        IcongeService ause;
        public CongeController(IcongeService ause)
        {
            this.ause = ause;
        }
        // GET: Auteur
        public ActionResult Index()
        {
            var l = ause.getAllConges();
            return View(l);
        }

        // GET: Auteur/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        public ActionResult Create()
        {

                return View();
         
        }

        // POST: Auteur/Create
        [HttpPost]
        public ActionResult Create(conge c)
        {
            
                if (ModelState.IsValid)
                {
                ause.AddConge(c);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }

               
            
        }

        // GET: Auteur/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Auteur/Edit/5
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

        // GET: Auteur/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Auteur/Delete/5
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
