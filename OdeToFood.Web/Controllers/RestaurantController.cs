using OdeToFood.Data.Entities;
using OdeToFood.Data.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly IRestaurantData db;

        public RestaurantController(IRestaurantData db)
        {
            this.db = db;
        }

        // GET: Restaurant
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        // GET: Restaurant/Details/5
        public ActionResult Details(int id)
        {
            var model = db.Get(id);
            if (model != null)
            {
                return View(model);
            }
            return View("NotFound");
        }

        // GET: Restaurant/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Restaurant/Create
        [HttpPost]
        public ActionResult Create(Restaurant restaurant)
        {

            if (ModelState.IsValid)
            {
                db.Add(restaurant);
                db.Commit();
                return RedirectToAction("Index");
            }

            return View();
        }

        // GET: Restaurant/Edit/5
        public ActionResult Edit(int id)
        {
            var model = db.Get(id);
            if(model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        // POST: Restaurant/Edit/5
        [HttpPost]
        public ActionResult Edit(Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                db.Update(restaurant);
                db.Commit();
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Restaurant/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Restaurant/Delete/5
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
