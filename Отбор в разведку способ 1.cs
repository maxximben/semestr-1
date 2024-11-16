using System;

namespace CSharp
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("введи N: ");
            int N = int.Parse(Console.ReadLine());
            int i = 0;
            double x_up = 0;
            double x_down = 0;
            while (Math.Pow(2, i) <= N)
            {
                x_up = Math.Pow(2, i + 1);
                x_down = Math.Pow(2, i);
                i++;
            }
            double delta = Math.Min(Math.Abs(N - x_down), Math.Abs(N - x_up));
            Console.WriteLine("Ответ: " + delta);
            Console.ReadKey();
        }
    }
}
