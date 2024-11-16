using System;

namespace CSharp
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("введи N: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Ответ: " + f(N));
        }

        static int f(int N)
        {
            if (N < 3) return 0;
            if (N == 3) return 1;
            int even = N / 2;
            int odd = N - even;
            return f(even) + f(odd);
        }
    }
}
