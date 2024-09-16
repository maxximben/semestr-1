using System;
namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int localMin = 0;

            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            
            if (b < a && b < c)
                localMin++;
            
            if (n > 3)
            {
                for (int i = 0; i < n - 3; i++)

                {
                    a = b; b = c;
                    c = Convert.ToInt32(Console.ReadLine());
                    if (a > b && b < c)
                        localMin++;
                }

            }
            Console.WriteLine("Локальных минимумов: " + localMin);
            Console.ReadKey();


        }
    }
}