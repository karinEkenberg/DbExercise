using DbExercise.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DbExercise.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DbExerciseContext dbExerciseContext;

        public HomeController(ILogger<HomeController> logger, DbExerciseContext dbExerciseContext)
        {
            _logger = logger;
            this.dbExerciseContext = dbExerciseContext;
        }

        public IActionResult Index()
        {
            var customer = dbExerciseContext.Customers.ToString();
            return View();
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
