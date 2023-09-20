using System;
namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Double.Parse(Console.ReadLine());
            double b = Double.Parse(Console.ReadLine());
            double c = Double.Parse(Console.ReadLine());
            double l = Double.Parse(Console.ReadLine());
            double h = Double.Parse(Console.ReadLine());
            double need_to_buy = ((((a * b + 2 * b * c + 2 * a * c) - (a * b + 2 * b * c + 2 * a * c) * 0.15) * 1000 * 1000) / (h * l)) + (((((a * b + 2 * b * c + 2 * a * c) - (a * b + 2 * b * c + 2 * a * c) * 0.15) * 1000 * 1000) / (h * l)) * 0.1);
            Console.WriteLine(Convert.ToInt32(need_to_buy));
        }
    }
}