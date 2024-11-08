// определить максимальную сумму подпоследовательности из чётных чисел
using System;

namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int max_sum = int.MinValue;
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = a;

            
            for (int i = 0; i < n - 1; i++)
            {
                int b = Convert.ToInt32(Console.ReadLine());
                if (a % 2 == 0 & b % 2 == 0)
                {
                    sum += b;
                    max_sum = Math.Max(sum, max_sum);
                }
                else
                {
                    sum = b;
                    if (b % 2 == 0) max_sum = Math.Max(sum, max_sum);
                }
                a = b;
            }
            Console.WriteLine("max_sum = " + max_sum);
            Console.ReadKey();
        }
    }
}
