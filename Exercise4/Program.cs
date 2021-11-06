using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ход");
            string chessMove = Console.ReadLine();

            char[] columns = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            int firstCol = Array.IndexOf(columns, chessMove[0]);
            int secondCol = Array.IndexOf(columns, chessMove[3]);
            int firstRow = chessMove[1] - '0';
            int secondRow = chessMove[4] - '0'; 
            if (firstCol == secondCol && firstRow == secondRow)
            {
                Console.WriteLine("Ход не был сделан.");
            }
            else if (firstCol == secondCol || firstRow == secondRow)
            {
                Console.WriteLine("Ход " + chessMove + " корректный.");
            }
            else if (Math.Abs(firstCol-secondCol) == Math.Abs(firstRow-secondRow))
            { 
                Console.WriteLine("Ход " + chessMove + " корректный.");
            }
            else 
            {
                Console.WriteLine("Ход " + chessMove + " некорректный.");
            }
        }
    }
}
