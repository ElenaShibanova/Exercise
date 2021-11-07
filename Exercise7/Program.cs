using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] letters = { "А","В","Е","К","М","Н","О","Р","С","Т","У","Х"};
            string[] numCar = new string[6];
            Random rnd = new Random();

            int value1 = rnd.Next(12);
            numCar[0] = letters[value1];
            int value2 = rnd.Next(10);
            numCar[1] =  value2.ToString();
            int value3 = rnd.Next(10);
            numCar[2] = value3.ToString();
            int value4 = rnd.Next(10);
            numCar[3] = value4.ToString();
            int value5 = rnd.Next(12);
            numCar[4] = letters[value5];
            int value6 = rnd.Next(12);
            numCar[5] = letters[value6];

            foreach (string symbol in numCar) 
            {
                Console.Write(symbol +" ");
            }
        
        }
    }
}
