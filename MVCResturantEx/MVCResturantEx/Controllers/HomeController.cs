using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCResturantEx2.data;
using MVCResturantEx2.data.Service;

namespace MVCResturantEx.Controllers
{
    public class HomeController : Controller
    {
        public SqlRestaurantData simDB;

        public HomeController(SqlRestaurantData simDB)
        {
            this.simDB = simDB;
        }
        public ActionResult Index()
        {
            var model = simDB.getAll();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Details(int id)
        {
            var model = simDB.getDetails(id);
            if (model == null)
            {
                return View("Index");
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ResturantModel resturant)
        {
            if (ModelState.IsValid)
            {
                simDB.Add(resturant);
                return RedirectToAction("Details", new {id = resturant.Id});
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = simDB.getDetails(id);
            if (model == null)
            {
                return View("Not Found");
            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ResturantModel resturant)
        {
            if (ModelState.IsValid)
            {
                simDB.update(resturant);
                return RedirectToAction("Edit", new { id = resturant.Id });
            }
            return View();
        }
        public ActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var resturant = simDB.getDetails(id);
                simDB.Remove(resturant);
                return RedirectToAction("Index", simDB.getAll());
            }

            return View();
        }
    }
}