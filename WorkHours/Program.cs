namespace WorkHours
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var workingDuration = new TimeSpan(0, 7, 30, 0);

            var breakDuration = new TimeSpan(0, 1, 0, 0);

            var startTime = new DateTime(2015, 06, 24, 8, 0, 0);

            var finishTime = new Core.WorkHours(workingDuration, breakDuration).CalculateFinishTime(startTime);

            Console.WriteLine("Daily working hours: {0}", workingDuration);
            Console.WriteLine("Starting at: {0}", startTime);
            Console.WriteLine("With a break of {0}", breakDuration);
            Console.WriteLine("Scheduled to finish at {0}", finishTime);

            Console.Read();
        }
    }
}
