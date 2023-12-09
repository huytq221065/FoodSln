using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Food.Web.Models;
using Food.Web.Repository;
using Microsoft.EntityFrameworkCore;

namespace Food.Web.Controllers
{

    public class HomeController:Controller
    {
        private readonly DataContext _datacontext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,DataContext context)
        {
            _logger = logger;
            _datacontext=context;
        }

        public IActionResult Index()
        {
            var products=_datacontext.Products.Include("Category").ToList();
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
