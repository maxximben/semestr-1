// Определить количество элементов меньших нуля
using System;
namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            Console.Write("Введи n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a;
            for (int i = 0; i < n; i++)
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a < 0) { s++; }
            }
            Console.WriteLine("Меньше нуля: " + s);
            Console.ReadKey();


        }
    }
}