using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCResturantEx.Models;

namespace MVCResturantEx.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        public ActionResult Index(string name)
        {
            var model = new GreetingViewModel();
            model.Message = ConfigurationManager.AppSettings["message"];
            model.Name = name ?? "No Name"; //Hvis name er tom, bliver den default som nu er "No Name"
            return View(model);
        }
    }
}