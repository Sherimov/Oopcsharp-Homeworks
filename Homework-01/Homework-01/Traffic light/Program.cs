using System;
using System.Threading;

namespace Traffic_light
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trafic lights...!");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Red light - STOP !!!");
            Thread.Sleep(6000);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Yellow - Prepare !!!");
            Thread.Sleep(3000);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Green light - GO !!!");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
