using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число, которое больше либо равно 2.");
            string s = Console.ReadLine();
            int UpperBound = int.Parse(s);
            int N = 2;
            List<int> PrimeNumbers = new List<int>();
            PrimeNumbers.Add(N);
            while (N < UpperBound)
            {
                N++;
                foreach (int num in PrimeNumbers)
                {
                    if  (N % num == 0)
                        break;
                    else if (num > Math.Sqrt(N))
                    { 
                        PrimeNumbers.Add(N);
                        break; 
                    }
                }
            }
            foreach (int num in PrimeNumbers)
                Console.WriteLine(num);
        }
    }
}
