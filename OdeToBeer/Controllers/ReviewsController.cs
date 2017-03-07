﻿using OdeToBeer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToBeer.Controllers
{
    public class ReviewsController : Controller
    {
        public ActionResult BestReview()
        {
            var bestReview = from r in _reviews
                             orderby r.Rating descending
                             select r;

            return PartialView("_Review", bestReview.First());
        }
        // GET: Reviews
        public ActionResult Index()
        {
            var model =
                from r in _reviews
                orderby r.Name
                select r;
            return View(model);
        }

        // GET: Reviews/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reviews/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reviews/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reviews/Edit/5
        public ActionResult Edit(int id)
        {
            var review = _reviews.Single(r => r.Id == id);
            return View(review);
        }

        // POST: Reviews/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var review = _reviews.Single(r => r.Id == id);
            if (TryUpdateModel(review))
            {
                // ...
                return RedirectToAction("Index");
            }
            return View(review);
        }

        // GET: Reviews/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reviews/Delete/5
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
        static List<BeerReviews> _reviews = new List<BeerReviews>
        {
            new BeerReviews
            {
                Id = 1,
                Name = "New Grist Gluten-Free",
                Company = "LakeFront Brewery",
                City = "Milwaukee, WI",
                Rating = "10",
                Comments = "This is a nice, smooth beer.",
                Type = "Pilsner"
            },
            new BeerReviews
            {
                Id = 2,
                Name = "Spotted Cow Grand Cru (Thumbprint Series)",
                Company = "New Glarus Brewing",
                City = "New Glarus, WI",
                Rating = "9",
                Comments = "This is a nice, smooth beer.",
                Type = "Ale"
            },
            new BeerReviews
            {
                Id = 3,
                Name = "Wisconsin Red Pale",
                Company = "Leinenkugel's",
                City = "Chippewa Falls, WI",
                Rating = "8.5",
                Comments = "This is a nice, smooth beer.",
                Type = "Ale"
            }
        };
    }
}
