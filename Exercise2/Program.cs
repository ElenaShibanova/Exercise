using System;
using System.Collections.Generic;
namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumX, sumY, sumX2, sumXY;
            sumX = 0;sumX2 = 0;sumXY = 0; sumY = 0;
            List<double[]> points = GetPointsFromUser();
            foreach (double[] point in points) 
            {
                sumX += point[0];
                sumY += point[1];
                sumXY += point[0] * point[1];
                sumX2 += point[0] * point[0];
            }
            double n = points.Count;
            double m = (sumXY - sumX * sumY / n) / ((sumX2 - sumX * sumX / n));
            double xAverage = sumX / n;
            double yAverage = sumY / n;
            double b = yAverage - m * xAverage;

            Console.WriteLine($"y = {m:F3}x + {b:F3}");
        }
        static List<double[]> GetPointsFromUser()
        {
            Console.WriteLine("Введите координаты. Для завершения введите q.");
            var points = new List<double[]>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "q") break;
                double[] xAndY = new double[2];
                string[] inputsDivided = input.Split(' ');
                xAndY[0] = double.Parse(inputsDivided[0]);
                xAndY[1] = double.Parse(inputsDivided[1]);
                points.Add(xAndY);
            }
            return points;
        }

    }
}
