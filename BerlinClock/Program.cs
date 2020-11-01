using System;
using ClockLibary;

namespace BerlinClock
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Berlin clock.");
            ReadTime();
        }

        static void ReadTime()
        {
            Console.WriteLine("Please enter a time (hh:mm:ss)");
            string givenTime = Console.ReadLine();
            ProcessTime(givenTime);
        }

        static void ProcessTime(String givenTime)
        {
            try
            {
                TimeSpan parsedTime = TimeSpan.Parse(givenTime);
                Clock clock = new Clock(parsedTime);

                Console.WriteLine("formatted String Output:");
                Console.WriteLine("################");
                Console.WriteLine(clock.GetTwoSecoundsIndicatorString());
                Console.WriteLine(clock.GetFiveHoursIndicatorString());
                Console.WriteLine(clock.GetOneHourIndicatorString());
                Console.WriteLine(clock.GetFiveMinutesIndicatorString());
                Console.WriteLine(clock.GetOneMinuteIndicatorString());
                Console.WriteLine("################");
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                ReadTime();
            }
        }
    }
}
