// ƒаны две переменные, помен€ть их значени€
using System;
namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine();
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);

            Console.ReadKey();
        }
    }
}