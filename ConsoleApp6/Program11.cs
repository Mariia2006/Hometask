using System;
namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int res = a + b;
            string a1 = a.ToString();
            string b1 = b.ToString();
            string ress = res.ToString();
            int ax = 10 - a1.Length;
            Console.SetCursorPosition(ax, 3);
            Console.WriteLine(a);
            int bx = 10 - b1.Length;  
            Console.SetCursorPosition(bx, 4);
            Console.WriteLine(b);
            Console.WriteLine("----------");
            int resx = 10 - ress.Length;
            Console.SetCursorPosition(resx, 6);
            Console.WriteLine(ress);
        }
    }
}