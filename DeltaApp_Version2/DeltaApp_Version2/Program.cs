using System;
using static System.Console;

namespace DeltaApp_Version2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int month;
            const double interior_mural1 = 450;
            const double interior_mural2 = 500;
            const double exterior_mural1 = 699;
            const double exterior_mural2 = 750;
            double total_int_mural = 0.0;
            double total_ext_mural = 0.0;
            double total_revenue = 0.0;
            
            WriteLine("****************Task1*****************");
            WriteLine("Enter the month");
            month = Convert.ToInt16(ReadLine());
            while (true)
            {
                if (month > 0 && month < 13)
                {

                    //interior_mural
                    WriteLine("***********************Task2****************");
                    double int_mural, ext_mural;
                    WriteLine("Enter the number of interior mural scheduled >>");
                    int_mural = Convert.ToInt16(ReadLine());

                    while (true)
                        if (int_mural > 0 && int_mural < 20)
                        {
                            WriteLine("Enter the number of exterior mural scheduled");
                            ext_mural = Convert.ToInt16(ReadLine());
                            while (true)
                            {
                                //exterior_mural
                                if (ext_mural > 0 && ext_mural < 20)
                                {
                                    if (month == 4 || month == 5 || month == 9 || month == 10)

                                    {
                                        total_ext_mural = exterior_mural1 * ext_mural;
                                        total_int_mural = interior_mural2 * int_mural;
                                        WriteLine("******************Task3************");
                                        WriteLine("{0} exterior mural are scheduled at {1} each for a total of {2}", ext_mural, exterior_mural1, total_ext_mural);
                                        WriteLine("{0} interior mural are scheduled at {1} each for total of {2}", int_mural, interior_mural2, total_int_mural);
                                        total_revenue = total_ext_mural + total_int_mural;
                                        WriteLine("Total revenue expected {0}", total_revenue);
                                        return;
                                    }
                                    else if (month == 12 || month == 1 || month == 2)
                                    {
                                        ext_mural = 0;
                                        total_ext_mural = exterior_mural2 * ext_mural;
                                        total_int_mural = interior_mural2 * int_mural;
                                        WriteLine("******************Task3************");
                                        WriteLine("{0} exterior mural are scheduled at {1} each for total of {2}", ext_mural, exterior_mural2, total_ext_mural);
                                        WriteLine("{0} interior mural are scheduled at {1} each for total of {2}", int_mural, interior_mural2, total_int_mural);
                                        total_revenue = total_ext_mural + total_int_mural;
                                        WriteLine("Total revenue expected {0}", total_revenue);
                                        return;

                                    }
                                    else if (month == 7 || month == 8)
                                    {
                                        total_ext_mural = exterior_mural2 * ext_mural;
                                        total_int_mural = interior_mural1 * int_mural;
                                        WriteLine("******************Task3************");
                                        WriteLine("{0} exterior mural are scheduled at {1} each for total of {2}", ext_mural, exterior_mural2, total_ext_mural);
                                        WriteLine("{0} exterior mural are scheduled at {1} each for total of {2}", int_mural, interior_mural1, total_int_mural);
                                        total_revenue = total_ext_mural + total_int_mural;
                                        WriteLine("Total revenue expected {0}", total_revenue);
                                        return;

                                    }
                                    else
                                    {
                                        total_ext_mural = exterior_mural2 * ext_mural;
                                        total_int_mural = interior_mural2 * int_mural;
                                        WriteLine("******************Task3************");
                                        WriteLine("{0} exterior mural are scheduled at {1} each for total of {2}", ext_mural, exterior_mural2, total_ext_mural);
                                        WriteLine("{0} interior mural are scheduled at {1} each for total of {2}", int_mural, interior_mural2, total_int_mural);
                                        total_revenue = total_ext_mural + total_int_mural;
                                        WriteLine("Total revenue expected {0}", total_revenue);
                                        return; 
                                    }
                                    
                                }
                                else
                                {
                                    WriteLine("Number of exterior must be between 0 and 20 inclusive");
                                    ext_mural = Convert.ToInt16(ReadLine());
                                    break;
                                }
                               

                            }
                           WriteLine("*******************Task4*****************");
                            WriteLine("Entering interior jobs:");
                            for(int i =0; i < int_mural; i++)
                            {
                                WriteLine("Enter Customer Name >> ");
                                string name = ReadLine();
                                WriteLine("Mural Options are :");
                                WriteLine("L for Lanscape");
                                WriteLine("S for Seascape");
                                WriteLine("A for Abstract");
                                WriteLine("enter mural style code >>");
                                char code = Console.ReadLine()[0];
                                int count_L = 0, count_S = 0, count_A = 0;
                                if (code == 'L' && code == 'l')
                                    count_L++;
                                else if (code == 'S' && code == 's')
                                    count_S++;
                                else if (code == 'A' && code == 'a')
                                    count_A++;
                                else
                                    WriteLine("{0} is not valid code", code);
                               
                            }

                            
                        }
                        else
                        {
                            WriteLine("Number of interior must be between 0 and 20 inclusive");
                            int_mural = Convert.ToInt16(ReadLine());
                            continue;

                        }
                }
                else
                {
                    WriteLine("Invalid month. Enter the month");
                    month = Convert.ToInt16(ReadLine());
                    continue;
                   

                }
               

            }
        }
       
    }
}
   