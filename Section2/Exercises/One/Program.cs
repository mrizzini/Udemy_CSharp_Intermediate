using System;

namespace One
{
    class ProgramStopWatch
    {
        static void Main(string[] args)
        {

            var stopwatch = new StopWatch();
            int one;
            do
            {
                System.Console.WriteLine("Enter 1 to start stopwatch: ");
                one = Convert.ToInt32(Console.ReadLine());
                // stopwatch.Start = DateTime.Now;
                stopwatch.Start();
                
                
                
            } while (one != 1);


            // if (one == 1)
            // {
            //     stopwatch.Start = DateTime.Now;
            // }


            System.Console.WriteLine("Enter 2 to stop stopwatch: ");
            int two = Convert.ToInt32(Console.ReadLine());

            if (two == 2)
            {
                // stopwatch.End = DateTime.Now;  
                stopwatch.End();
            }
  
            System.Console.WriteLine(stopwatch.Duration());
        }
    }
}
