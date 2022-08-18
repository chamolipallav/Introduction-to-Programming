using System;

namespace DeltaApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //task 1
            Console.WriteLine("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
            Console.WriteLine("M                            M");
            Console.WriteLine("M                            M");
            Console.WriteLine("M Make your vision your view M");
            Console.WriteLine("M                            M");
            Console.WriteLine("M                            M");
            Console.WriteLine("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");

            //task2
            const int interior = 500;
            const int exterior = 750;
            int int_mural, ext_mural, revenue;
            
            Console.WriteLine("ENTER THE VALUE OF INTERIOR MURALS");
            int_mural = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER THE VALUE OF EXTERIAL MURALS");
            ext_mural = Convert.ToInt32(Console.ReadLine());
     
            revenue = (interior * int_mural) + (exterior * ext_mural);

            Console.WriteLine("TOTAL REVENUE IS {0}", revenue.ToString("c"));

            Boolean comp;
            comp = (int_mural > ext_mural);
     
            Console.WriteLine("inteiral murial are scheduled than exterial murial " +comp);
            
            
        }
    }
}