using System;
using System.Collections.Generic;
using System.Web.Mvc;
using CampusFeedbackHub.Models;

namespace CampusFeedbackHub.Controllers
{
    public class ReviewController : Controller
    {
        private static List<ReviewModel> reviewStorage = new List<ReviewModel>();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewReview()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewReview(ReviewModel model)
        {
            if (ModelState.IsValid)
            {
                reviewStorage.Add(model);
                return RedirectToAction("History");
            }
            return View(model);
        }

        public ActionResult History()
        {
            return View(reviewStorage);
        }
    }
}