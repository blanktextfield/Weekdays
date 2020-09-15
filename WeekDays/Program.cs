using System;

namespace WeekDays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What day is today?");
            string day = Console.ReadLine().ToLower();
            if(day == "monday" || day == "tuesday" || day == "tuesday" || day == "thursday" || day == "friday")
            {
                Console.WriteLine($"{day} is a workday");
            }else if (day == "saturday" || day == "sunday")
            {
                Console.WriteLine("it`s weekend");
            }else
            {
                Console.WriteLine("That answer is not a day");
            }
        }
    }
}
