using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] password = new char[8];
            Random rnd = new Random();

            password[0] = (char)rnd.Next(48, 58);
            password[1] = (char)rnd.Next(65, 91);
            password[2] = (char)rnd.Next(97, 123);
            for (int i = 3; i <= 7; i++)
            {
                password[i] = (char)rnd.Next(33, 128);
            }
            for (int i = 0; i <= 7; i++)//случайная перестановка элементов в массиве
            {
                int j = rnd.Next(8);
                var temp = password[j];
                password[j] = password[i];
                password[i] = temp;
            }
            foreach (char symbol in password)
            {
                Console.Write(symbol);
            }
            
        }
    }
}

