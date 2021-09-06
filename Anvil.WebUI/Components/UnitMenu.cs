using System.Linq;
using Anvil.Tracker.Model;
using Anvil.Tracker.Service;
using Microsoft.AspNetCore.Mvc;

namespace Anvil.WebUI.Components
{
    public class UnitMenu : ViewComponent
    {
        private readonly ITrackerService _trackerService;

        public UnitMenu(ITrackerService trackerService)
        {
            _trackerService = trackerService;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _trackerService.GetTrackers();

            var milesType = new AirCraftAltitudeType
            {
                Units = categories
                    .Select(m => m.AltitudeType)
                    .Distinct()
            };

            return View(milesType);
        }
    }
}
