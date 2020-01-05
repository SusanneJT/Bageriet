using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bageriet.Models;
using Bageriet.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bageriet.Controllers
{
    [Authorize]
    public class RatingController : Controller
    {
        private readonly IRatingRepository _ratingRepository;
        private readonly IBreadRepository _breadRepository;

        public RatingController(IRatingRepository ratingRepository, IBreadRepository breadRepository)
        {
            _ratingRepository = ratingRepository;
            _breadRepository = breadRepository;

        }

        // GET: /<controller>/
        public IActionResult RateBread(int id)
        {
            var bread = _breadRepository.GetBreadById(id);
            if (bread == null)
                return NotFound();

            ViewBag.BreadId = bread.BreadId;
            ViewBag.BreadImg = bread.ImageUrl;
            return View();
        }

        [HttpPost]
        public IActionResult RateBread(Rating rating, int id)
        {
            var bread = _breadRepository.GetBreadById(id);
            rating.Bread = bread;
            rating.BreadId = id;
            if (ModelState.IsValid)
            {
                _ratingRepository.CreateRating(rating);
                return RedirectToAction("RatingComplete");
            }
            ViewBag.BreadId = id;
            ViewBag.BreadImg = bread.ImageUrl;
            return View(rating);
        }

        public IActionResult RatingComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Tack för ditt betyg!";
            return View();
        }
    }
}
