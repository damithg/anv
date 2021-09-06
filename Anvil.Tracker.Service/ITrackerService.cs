using System.Collections.Generic;
using Anvil.Tracker.Model;

namespace Anvil.Tracker.Service
{
    public interface ITrackerService
    {
        IEnumerable<AirCraftModel> GetTrackers();
    }
}