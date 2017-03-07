using OdeToBeer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToBeer.Controllers
{
    public class HomeController : Controller
    {
        MyBeerBlogDb _db = new MyBeerBlogDb();
        public ActionResult Index()
        {
            var model = _db.Beers.ToList();
            return View();
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

        protected override void Dispose(bool disposing)
        {
            if(_db != null)
            {
                _db.Dispose(); //Cleaning up memory
            }
            base.Dispose(disposing);
        }
    }
}