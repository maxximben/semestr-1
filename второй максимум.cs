//Найти второй максимальный элемент

using System;
namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int max1 = Convert.ToInt32(Console.ReadLine()); ;
            int max2 = -2000000000;
            int a;
            for (int i = 0; i < n - 1; i++)
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a > max2)
                {
                    max2 = a;
                }
                if (a > max1)
                {
                    max2 = max1;
                    max1 = a;
                }
            }
            Console.WriteLine("max2: " + max2);
            Console.ReadKey();
        }
    }
}
