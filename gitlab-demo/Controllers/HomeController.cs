using gitlab_demo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace gitlab_demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
		private readonly ICustomerModel _customerModel;

        public HomeController(ILogger<HomeController> logger, ICustomerModel customerModel)
        {
            _logger = logger;
            _customerModel = customerModel;
        }

        public IActionResult Index()
        {
            return View(_customerModel.GetCustomers());
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