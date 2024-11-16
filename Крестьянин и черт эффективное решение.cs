using System;

namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            Console.Write("введи Max_N: ");

            double max_n = Convert.ToUInt64(Console.ReadLine());

            for (int x = 1; x <= Math.Log(max_n, 2)+1; x++) {
                sum += Convert.ToInt32(Math.Floor(max_n / (Math.Pow(2, x) - 1)));
            }
            Console.WriteLine("Ответ: " + sum);
            Console.ReadKey();
        }
    }
}
