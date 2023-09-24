using System;
namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string team1 = Console.ReadLine();
            string goal1 = Console.ReadLine();
            string team2 = Console.ReadLine();
            string goal2 = Console.ReadLine();
            string colon = " : ";
            int team1x = 13 - team1.Length;
            Console.SetCursorPosition(team1x, 4);
            Console.Write($"{team1}");
            Console.SetCursorPosition(13, 4);
            Console.Write(colon);
            Console.Write($"{team2}");
            Console.SetCursorPosition(12, 5);
            Console.Write($"{goal1}");
            Console.Write(colon);
            Console.Write($"{goal2}");
        }
    }
}