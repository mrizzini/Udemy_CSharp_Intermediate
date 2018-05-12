using System;
using System.Threading;

namespace StopWatchCodeAlong
{
    public class Program
    {

    static void Main(string[] args)
        {

            var stopwatch = new StopWatch();

            for (var i = 0; i < 2; i++)
            {
                stopwatch.Start();

                Thread.Sleep(1000);

                stopwatch.Stop();

                System.Console.WriteLine("Duration: " + stopwatch.GetInterval());
                System.Console.WriteLine("Press enter to run stopwatch one more time");
                Console.ReadLine();
            }
            }
        }
    

    public class StopWatch
    {
        // public DateTime StartTime { get; set; }
        // public DateTime EndTime { get; set; }
        // These properties should be private. These are the implenetation detail
        // We want to have public methods that work on the properties
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _running; // bools are auto declared as false

        // public void Start(DateTime start) should not take a parameter
        public void Start()
        {
            if (_running)
            {
                throw new InvalidOperationException("Stopwatch is already running");
            }
            else
            {
                // StartTime = start;                
                _startTime = DateTime.Now;
                _running = true;
            }
        }

        // public void Stop(DateTime stop) should not take a parameter
        public void Stop()
        {
            if (!_running)
            {
                throw new InvalidOperationException("Stopwatch is not running");
            }
            else
            {
                // EndTime = stop;
                _endTime = DateTime.Now;                
                _running = false;
            }
        }

        public TimeSpan GetInterval()
        {
            // var duration = EndTime - StartTime;
            // return duration;
            // don't need the variable
            return _endTime - _startTime;
        }

    }
}


    
   
