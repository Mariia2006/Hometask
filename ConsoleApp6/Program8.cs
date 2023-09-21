using System;
namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Trim().Split();
            double p = double.Parse(data[0]);
            double x = double.Parse(data[1]);
            double y = double.Parse(data[2]);
            if (x <= 100 && x >= 1 && y >= 1 && y <= 100 && p >= 1 && p <= 1000)
            {
                double var = p / (x+y);
                double a = x * var;
                double b = y * var;
                Console.WriteLine($"{a*b}");
            }
        }
    }
}
