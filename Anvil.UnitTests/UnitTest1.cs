using System.Linq;
using Anvil.Tracker.Service;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace Anvil.UnitTests
{
    public class TrackingServiceTests
    {
        private readonly TrackerService _trackerService;

        public TrackingServiceTests()
        {
            var logger = new Mock<ILogger<TrackerService>>();
            _trackerService = new TrackerService(logger.Object);
        }
        
        [Fact(DisplayName = "GIVEN a valid request " + 
                            "WHEN requesting provider " + 
                            "THEN 4 providers returned "
        )]
        public void TrackingServiceTests_ValidRequest_ReturnProviders()
        {
            var result = _trackerService.GetTrackers();
            result.Count().Should().BeGreaterOrEqualTo(4);
        }
    }
}
