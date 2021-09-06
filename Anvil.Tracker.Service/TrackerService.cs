using System;
using System.Collections.Generic;
using System.Linq;
using Anvil.Tracker.Model;
using AnvilMonitoringTest;
using Microsoft.Extensions.Logging;

namespace Anvil.Tracker.Service
{
    public class TrackerService : ITrackerService
    {
        private readonly ILogger<TrackerService> _logger;

        public TrackerService(ILogger<TrackerService> logger)
        {
            _logger = logger;
        }

        public IEnumerable<AirCraftModel> GetTrackers()
        {
            try
            {
                var trackers = new TrackerFactory().GetTrackers();

                return trackers
                    .Select(dataProvider => new AirCraftModel
                    {
                        AltitudeType = dataProvider.AltitudeType.ToString(), 
                        VelocityType = dataProvider.VelocityType.ToString(),
                        Altitude = dataProvider.GetAltitude().ToString(), 
                        Velocity = dataProvider.GetVelocity().ToString()
                    }).ToList();
            }
            catch (Exception exception)
            {
                 _logger.LogError(exception, "Unable to access the altitude data at the time");
                throw;
            }
        }
    }
}
