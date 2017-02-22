using domain.Entities;
using service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;


namespace Web.Controllers
{
    public class CongeController : Controller
    {
        CongeService a;
        public CongeController(CongeService a)
        {
            this.a = a;
        }
        // GET: Conge
        public ActionResult Index()
        {
            var l = a.getAllConge();
            return View(l);
        }

        


        public ActionResult IndexBack()
        {
            var l = a.getAllConge();
            return View(l);
        }


        // GET: Conge/Details/5
        public ActionResult Details(int id)
        {
            conge c = a.getCongeById(id);
            if (c==null)
            { return HttpNotFound(); }
            return View(c);
        }

        // GET: Conge/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Conge/Create
        [HttpPost]
        public ActionResult Create(conge h)
        {
            if (ModelState.IsValid)
            {
                a.addConge(h);

                return RedirectToAction("IndexBack");
            }


            else

                return View();
        }

        // GET: Conge/Edit/5
        public ActionResult Edit(int id)
        {
            conge h = a.getCongeById(id);
            a.deleteCongeById(id);
            return View(h);
        }

        // POST: Conge/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, conge h)
        { try {
                // if (ModelState.IsValid)

                //  a.addConge(h);

                return RedirectToAction("Index"); }
            catch { return View(); }
        }


        // GET: Conge/Delete/5
        public ActionResult Delete(int id)
        {
            a.deleteCongeById(id);
            var hs = a.getAllConge();
            return RedirectToAction("Index", hs);
        }

        // POST: Conge/Delete/5
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
