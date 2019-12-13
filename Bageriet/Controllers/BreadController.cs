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

        public BreadController(IBreadRepository breadRepository, IProductRepository productRepository)
        {
            _breadRepository = breadRepository;
            _productRepository = productRepository;
        }

        public ViewResult Bread()
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
    }
}
