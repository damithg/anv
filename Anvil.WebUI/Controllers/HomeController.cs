using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using Anvil.Tracker.Service;
using Anvil.WebUI.ViewModels;

namespace Anvil.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITrackerService _trackerService;

        public HomeController(
            ILogger<HomeController> logger,
            ITrackerService trackerService)
        {
            _logger = logger;
            _trackerService = trackerService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Tracker(string category)
        {
            var model = new AirCraftViewModel();

            var result = _trackerService.GetTrackers();

            if (string.IsNullOrEmpty(category))
            {
                model.AirCraftModels = result;
                model.CurrentUnitType = "All units";
            }
            else
            {
                model.AirCraftModels = result.Where(p => p.AltitudeType == category);
                model.CurrentUnitType = category;
            }
            
            return View(model);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
