using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using wEBFORMapp.Models;

namespace wEBFORMapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Prn211ProjectContext projectContext = new Prn211ProjectContext();
            List<Ticket>ticketslist=projectContext.Tickets.ToList();

            return View(ticketslist);
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