// определить максимальный размер последовательности, состоящей из одинаковых элементов
using System;
namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int max = 1;
            int len = 1;
            
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n-1; i++)
            {
                int b = Convert.ToInt32(Console.ReadLine());
                if (a == b)
                {
                    len++;
                    max = Math.Max(len, max);
                }
                else 
                {
                    len = 1;
                }
                a = b;
            }
            Console.WriteLine("max = " + max);
            
            Console.ReadKey();
            
        }
    }
}
