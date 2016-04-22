namespace WorkHours.Tests
{
    using System;

    using FluentAssertions;

    using Xunit;

    public class Tests
    {
        [Fact]
        public void should_calculate_finish_time()
        {
            var workingDuration = new TimeSpan(0, 7, 30, 0); // 7.5 hours

            var lunchDuration = new TimeSpan(0, 1, 0, 0); // 1 hour

            var startTime = new DateTime(2015, 06, 24, 8, 0, 0); // Starts work at 0800

            var finishTime = new DateTime(2015, 06, 24, 16, 30, 0); // Finishes work at 1630

            var calculatedFinishTime = new Core.WorkHours(workingDuration, lunchDuration).CalculateFinishTime(startTime);

            calculatedFinishTime.Should().Be(finishTime);
        }

        [Fact]
        public void should_calculate_start_time()
        {
            var workingDuration = new TimeSpan(0, 7, 30, 0); // 7.5 hours

            var lunchDuration = new TimeSpan(0, 1, 0, 0); // 1 hour

            var startTime = new DateTime(2015, 6, 5, 9, 30, 0); // Should have starter work at at 0930

            var finishTime = new DateTime(2015, 6, 5, 18, 0, 0); // Finishes work at 1800

            var calculatedStartTime = new Core.WorkHours(workingDuration, lunchDuration).CalculateStartTime(finishTime);

            calculatedStartTime.Should().Be(startTime);
        }
    }
}
