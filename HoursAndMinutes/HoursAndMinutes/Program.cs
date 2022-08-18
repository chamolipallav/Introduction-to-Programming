using System;

namespace HoursAndMinutes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int hr, min, total;
            Console.WriteLine("enter work minutes");
            total = Convert.ToInt16(Console.ReadLine());

            hr = total / 60;
            min = total % 60;

            Console.WriteLine("{0} hours and {1} minutes in {2}", hr, min, total);
        }
    }
}
