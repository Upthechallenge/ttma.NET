using domain.Entities;
using service;
using System;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class EventController : Controller
    {
        EventService a;
        public EventController(EventService a)
        {
            this.a = a;
        }
        // GET: Event
        public ActionResult Index()
        {
            var l = a.getAllEvents();
            return View(l);
        }
        public ActionResult Indexfront()
        {
            var l = a.getAllEvents();
            return View(l);
        }

        // GET: Event/Details/5
        public ActionResult Details(int id)
        {
            evenement d = a.getEventById(id);
            if (d == null)
            {
                return HttpNotFound();
            }
            return View(d);
        }

        // GET: Event/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Event/Create
        [HttpPost]
        public ActionResult Create(evenement h)
        {
            if (ModelState.IsValid)
            {
                a.addEvent(h);

                return RedirectToAction("Index");
            }


            else

                return View();
        }

        // GET: Event/Edit/5
        public ActionResult Edit(int id)
        {
            evenement h = a.getEventById(id);
            a.deleteEventById(id);
            return View();
        }

        // POST: Event/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, evenement h)
        {
            if (ModelState.IsValid)

                a.addEvent(h);

            return RedirectToAction("Index");
        }

        // GET: Event/Delete/5
        public ActionResult Delete(evenement aa)
        {
            //a.deleteEv(p);
            //var hs = a.getAllEvents();
            //return RedirectToAction("Index", hs);
            return View();
        }

        // POST: Event/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            a.deleteEvent(id);
            return RedirectToAction("Index");
           
        }
    }
}
