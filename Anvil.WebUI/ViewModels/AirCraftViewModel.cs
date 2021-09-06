using System.Collections.Generic;
using Anvil.Tracker.Model;

namespace Anvil.WebUI.ViewModels
{
    public class AirCraftViewModel
    {
        public string CurrentUnitType { get; set; }
        public IEnumerable<AirCraftModel> AirCraftModels { get; set; }
    }
}
