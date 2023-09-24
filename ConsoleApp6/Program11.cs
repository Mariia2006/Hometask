using System;
namespace ConsoleApp15
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
            while (a1[^1] != a1[9])
            {
                a1 = " " + a1;
            }
            while (b1[^1] != b1[9])
            {
                b1 = " " + b1;    
            }
            while (ress[^1] != ress[9])
            {
                ress = " " + ress;  
            }
            Console.WriteLine(a1);
            Console.WriteLine(b1);
            Console.WriteLine("----------");
            Console.WriteLine(ress);
        }
    }
}
