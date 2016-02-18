namespace WorkHours.Core
{
    using System;

    public class WorkHours
    {
        private TimeSpan WorkingDuration { get; set; }

        private TimeSpan LunchDuration { get; set; }

        private DateTime StartTime { get; set; }

        private DateTime FinishTime { get; set; }

        public WorkHours(TimeSpan workingDuration, TimeSpan lunchDuration)
        {
            this.WorkingDuration = workingDuration;
            this.LunchDuration = lunchDuration;
        }

        public DateTime CalculateFinishTime(DateTime startTime)
        {
            this.StartTime = startTime;

            return this.StartTime + this.WorkingDuration + this.LunchDuration;
        }

        public DateTime CalculateStartTime(DateTime finishTime)
        {
            this.FinishTime = finishTime;

            return this.FinishTime - this.WorkingDuration - this.LunchDuration;
        }
    }
}
