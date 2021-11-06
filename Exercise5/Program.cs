using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months =
                {"января","февраля","марта","апреля","мая","июня",
                "июля","августа","сентября","октября","ноября","декабря"};
            int[] longMonths = {1,3,5,7,8,10,12};
            int[] shortMonths = {4,6,9,11};
            int year = 0;
            foreach (int month in longMonths)
                
            {
                for (int i = 1; i <= 31; i++)
                {
                    year = i * month;
                    if (year >= 100) break;
                    else
                    {
                        Console.WriteLine($"{i} {months[month - 1]} 20{year:D2}"); 
                    }
                }
            }
            foreach (int month in shortMonths)

            {
                for (int i = 1; i <= 30; i++)
                {
                    year = i * month;
                    if (year >= 100) break;
                    else
                    {
                        Console.WriteLine($"{i} {months[month - 1]} 20{year:D2}");
                    }
                }
            }
            for (int i = 1; i <= 28; i++)
            {
                year = i * 2;
                Console.WriteLine($"{i} февраля 20{year:D2}");
                
            }
            


        }
    }
}
