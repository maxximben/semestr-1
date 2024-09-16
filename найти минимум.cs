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

            int m = Math.Abs(a - b);

            int min = (a + b - m) / 2;

            Console.WriteLine(min);
            Console.ReadKey();
            
        }
    }
}