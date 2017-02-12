using domain.Entities;
using service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HotelController : Controller
    {
        HotelService a;
        ReservationService r;
        UserService u;
        public HotelController(HotelService a, ReservationService r, UserService u)
        {
            this.a = a;
            this.r = r;
            this.u = u;
        }
        // GET: Hotel
        public ActionResult Index(string searchString)
        {
            var l = a.getAllHotels();

            var movies = from m in l
                         select m;

            
          
            if (!String.IsNullOrEmpty(searchString))
            {
                // list = list.Where(s => s.name.Contains(searchString));
                movies = movies.Where(hotel => hotel.name==searchString).ToList();
            }

            return View(movies);
        }

        public ActionResult IndexFront(string searchString)
        {
            var l = a.getAllHotels();

            var movies = from m in l
                         select m;



            if (!String.IsNullOrEmpty(searchString))
            {
                // list = list.Where(s => s.name.Contains(searchString));
                movies = movies.Where(hotel => hotel.name == searchString).ToList();
            }

            return View(movies);
        }
        public ActionResult ClientEvents(bool? clickable, bool? draggable)
        {
            ViewData["clickable"] = clickable ?? true;
            ViewData["draggable"] = draggable ?? true;
            return View();
        }
        public ActionResult Geocoding()
        {
            var l = a.getAllHotels();
            List<HotelViewModel> PVM = new List<HotelViewModel>();
            foreach (var item in l)
            {
                PVM.Add(
                    new HotelViewModel
                    {
                        id = item.id,
                        name = item.name,
                        adresse = item.adresse,
                        description = item.description,
                        roomNumber = item.roomNumber,
                        star = item.star,
                        adressbylonlat= item.latitude+","+ item.longitude,
                        latitude = item.latitude,
                        longitude = item.longitude,
                        PhotoString = "data:image/png;base64," + Convert.ToBase64String(item.pic)
                    });
            }
            return View(PVM);
        }

        public ActionResult DataBindingToModel()
        {
            var l = a.getAllHotels();
            List<HotelViewModel> PVM = new List<HotelViewModel>();
            foreach (var item in l)
            {
                PVM.Add(
                    new HotelViewModel
                    {
                        id = item.id,
                        name = item.name,
                        adresse = item.adresse,
                        description = item.description,
                        roomNumber = item.roomNumber,
                        star = item.star,
                        latitude = item.latitude,
                        longitude = item.longitude,
                        lon= Convert.ToInt64(item.longitude),
                        lat = Convert.ToInt64(item.latitude),
                        PhotoString = "data:image/png;base64," + Convert.ToBase64String(item.pic)
                    });
            }
            return View(PVM);
        }

        public ActionResult DataBindingToStar()
        {
            var l = a.getAllHotels();
            List<HotelViewModel> PVM = new List<HotelViewModel>();
            foreach (var item in l)
            {
                PVM.Add(
                    new HotelViewModel
                    {
                        id = item.id,
                        name = item.name,
                        adresse = item.adresse,
                        description = item.description,
                        roomNumber = item.roomNumber,
                        star = item.star,
                        latitude = item.latitude,
                        longitude = item.longitude,
                        lon = Convert.ToInt64(item.longitude),
                        lat = Convert.ToInt64(item.latitude),
                        PhotoString = "data:image/png;base64," + Convert.ToBase64String(item.pic)
                    });
            }
            return View(PVM);
        }

        public ActionResult NearBy()
        {
            var l = a.getAllHotels();
            List<HotelViewModel> PVM = new List<HotelViewModel>();
            foreach (var item in l)
            {
                PVM.Add(
                    new HotelViewModel
                    {
                        id = item.id,
                        name = item.name,
                        adresse = item.adresse,
                        description = item.description,
                        roomNumber = item.roomNumber,
                        star = item.star,
                        latitude = item.latitude,
                        longitude = item.longitude,
                        lon = Convert.ToInt64(item.longitude),
                        lat = Convert.ToInt64(item.latitude),
                        PhotoString = "data:image/png;base64," + Convert.ToBase64String(item.pic)
                    });
            }
            return View(PVM);
        }

        public ActionResult Marker(int id)
        {
            hotel h = new hotel();
            h = a.getHotelById(id);
            String lat = h.latitude;
            String lon = h.longitude;

            ViewBag.lon = Convert.ToInt64(lon);
            ViewBag.lat = Convert.ToInt64(lat);
            return View();
        }

        public ActionResult MarkerWithoutLoc(int id)
        {
            hotel h = new hotel();
            h = a.getHotelById(id);
            String lat = h.latitude;
            String lon = h.longitude;

            ViewBag.lon = Convert.ToInt64(lon);
            ViewBag.lat = Convert.ToInt64(lat);
            return View();
        }

        // GET: Hotel/Details/5
        public ActionResult Details(int id)
        {
            hotel h = new hotel();
            h = a.getHotelById(id);
            HotelViewModel hv = new HotelViewModel() {
                id = h.id,
                name=h.name,
                adresse=h.adresse,
                description=h.description,
                roomNumber=h.roomNumber,
                star=h.star,
                latitude=h.latitude,
                longitude=h.longitude,
                PhotoString = "data:image/png;base64," + Convert.ToBase64String(h.pic)

            };
            return View(hv);
        }

        // GET: Hotel/Create
        public ActionResult Create()
        {
            HotelViewModel fvm = new HotelViewModel();
            return View(fvm);
        }

      /*  public ActionResult CreateReservation()
        {
          /*  ReservationViewModel pvm = new ReservationViewModel();
            pvm.Hotels = a.getAllHotels().toToSelectListItems();
            pvm.Users = u.getAllusers().ToSelectListItems();
            

            

            return View(pvm);

        }*/

        // POST: Hotel/Create
        [HttpPost]
        public ActionResult Create(HotelViewModel fvm, HttpPostedFileBase Image)
        {
            //  if (!ModelState.IsValid || Image == null || Image.ContentLength == 0)
            //    {
            //    return RedirectToAction("Create");
            //  }

            Image = Request.Files["Image"];
          

                MemoryStream target = new MemoryStream();
            Image.InputStream.CopyTo(target);
          

            byte[] trtr;

            trtr = target.ToArray();

            hotel h = new hotel() {
                name=fvm.name,
                adresse=fvm.adresse,
                description=fvm.description,
                longitude=fvm.longitude,
                latitude=fvm.latitude,
                pic= trtr,
                star=fvm.star,
                roomNumber=fvm.roomNumber
            };
            a.addHotel(h);
            
            return RedirectToAction("Index");
        }
        public ActionResult google(string address)
        {
            return
    View((object)(address));
        }

        // GET: Hotel/Edit/5
        public ActionResult Edit(int id)
        {
            hotel h = new hotel();
            
            
            h = a.getHotelById(id);
            HotelViewModel fvm = new HotelViewModel()
            {
                id = h.id,
                name = h.name,
                adresse = h.adresse,
                description = h.description,
                roomNumber = h.roomNumber,
                star = h.star,
                latitude = h.latitude,
                longitude = h.longitude,
                PhotoString = "data:image/png;base64," + Convert.ToBase64String(h.pic)

            };



            a.deleteHotelById(id);
            return View(fvm);
            
        }

        // POST: Hotel/Edit/5
        [HttpPost]
        public ActionResult Edit(HotelViewModel fvm, HttpPostedFileBase Image)
        {
            if (ModelState.IsValid)

                Image = Request.Files["Image"];


            MemoryStream target = new MemoryStream();
            Image.InputStream.CopyTo(target);


            byte[] trtr;

            trtr = target.ToArray();

            hotel h = new hotel()
            {
                name = fvm.name,
                adresse = fvm.adresse,
                description = fvm.description,
                longitude = fvm.longitude,
                latitude = fvm.latitude,
                pic = trtr,
                star = fvm.star,
                roomNumber = fvm.roomNumber
            };
            
           
                a.addHotel(h);
            

            return RedirectToAction("Index");
        }

        // GET: Hotel/Delete/5
        public ActionResult Delete(int id)
        {
            a.deleteHotelById(id);
            var hs = a.getAllHotels();
            return RedirectToAction("Index", hs);
        }

        // POST: Hotel/Delete/5
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