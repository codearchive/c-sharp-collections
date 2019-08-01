using System;

namespace module_02
{
    class Program
    {
        static void Main()
        {
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            Console.WriteLine("Before:");
            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }
            

            Console.WriteLine("\nWhich day do you want to display");
            Console.WriteLine("(Monday = 1, etc.) > ");
            int iDay = int.Parse(Console.ReadLine());

            string choseDay = daysOfWeek[iDay - 1];
            Console.WriteLine($"That day is {choseDay}");

            daysOfWeek[1] = "Wednesday";

            Console.WriteLine("\r\nAfter:");
            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }
        }
    }
}
