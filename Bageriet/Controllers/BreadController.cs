using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bageriet.Models;
using Bageriet.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//Controller for the bread page
namespace Bageriet.Controllers
{
    public class BreadController : Controller
    {
        private readonly IBreadRepository _breadRepository;
        private readonly IProductRepository _productRepository;
        private readonly IRatingRepository _ratingRepository;


        public BreadController(IBreadRepository breadRepository, IProductRepository productRepository, IRatingRepository ratingRepository)
        {
            _breadRepository = breadRepository;
            _productRepository = productRepository;
            _ratingRepository = ratingRepository;
        }

        public ViewResult BreadList()
        {
            BreadListViewModel breadListViewModel = new BreadListViewModel
            {   
                //All bread and products are added to the breadListViewModel
                Bread = _breadRepository.AllBread,
                Products = _productRepository.AllProducts
            };

            //The created view is returned to the bread page (Bread.cshtml)
            return View(breadListViewModel);
        }

        public IActionResult BreadView(int id)
        {

            double avarage = 0;
            foreach (var rating in _ratingRepository.GetAllRatings(id))
            {
                avarage = avarage += rating.Grade;
            }
            double avarageGrade = avarage / _ratingRepository.GetAllRatings(id).Count();

            if (double.IsNaN(avarageGrade))
                avarageGrade = 0;


            BreadDetailsView breadDetailsView = new BreadDetailsView
            {
                Bread = _breadRepository.GetBreadById(id),
                Ratings = _ratingRepository.GetAllRatings(id),
                AvarageGrade = avarageGrade
            };
            return View(breadDetailsView);
        }
    }
}
