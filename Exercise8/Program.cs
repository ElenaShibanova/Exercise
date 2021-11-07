using System;
using System.Collections.Generic;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество букв в массиве:");
            int numberOfLetters = int.Parse(Console.ReadLine());
            string[] letters = GetLettersFromUser(numberOfLetters);
            int quantityLetters = 1;
            List<string> codeLetters = new List<string>();
            for (int i = 0; i < numberOfLetters - 1; i++)
            {
                if (letters[i] == letters[i + 1])
                {
                    quantityLetters++;
                    if (i == numberOfLetters - 2)
                    {
                        codeLetters.Add(letters[i]);
                        string strQLett = quantityLetters.ToString();
                        codeLetters.Add(strQLett);
                    }
                }
                else
                {
                    codeLetters.Add(letters[i]);
                    string strQLett = quantityLetters.ToString();
                    codeLetters.Add(strQLett);
                    quantityLetters = 1;

                    if (i == numberOfLetters - 2)
                    {
                        codeLetters.Add(letters[i + 1]);
                        codeLetters.Add("1");
                    }
                }
            }
            foreach (string letter in codeLetters)
            {
                Console.Write(letter + " ");
            }
        }
        static string[] GetLettersFromUser(int numOfLetters)
        {
            Console.WriteLine("Введите буквы:");
            var letters = new string[numOfLetters];

            for (int i = 0; i < numOfLetters; i++)
            {
                letters[i] = Console.ReadLine();
            }
            return letters;
        }
    }
}

