using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bageriet.Controllers
{
    public class BreadController : Controller
    {
        private readonly ILogger<BreadController> _logger;
        public BreadController(ILogger<BreadController> logger)
        {
            _logger = logger;
        }
        // GET: /<controller>/
        public IActionResult Bread()
        {
            return View();
        }
    }
}
