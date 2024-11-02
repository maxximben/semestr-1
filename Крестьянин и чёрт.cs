using System;

namespace CSharp
{
    internal class Program
    {
        static int f(int max_n, int k)
        {
            double money = 0;
            int c = 0;
            while (true)
            {
                money = (money + k) / 2;
                if (money % 1 != 0)
                    break;
                if (money <= max_n)
                    c++;
            }
            return c;
        }

        static void Main(string[] args)
        {
            int count = 0;
            Console.Write("введи Max_N: ");
            int max_n = Int32.Parse(Console.ReadLine());
            for (int k = 1; k < max_n * 2 + 1; k++)
            {
                count += f(max_n, k);
            }
            Console.WriteLine("Ответ: " + count);
            Console.ReadKey();
        }
    }
}
