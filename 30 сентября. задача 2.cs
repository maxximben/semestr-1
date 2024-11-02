using System;
//Определить минимальную длину подпоследовательности, состоящей из нулей
namespace CSharp
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Ведите n: ");
            int n = Int32.Parse(Console.ReadLine());
            int a; int len = 0;
            int min = n + 1;
            for (int i = 0; i < n; i++)
            {
                a = Int32.Parse(Console.ReadLine());
                if (a == 0)
                    len++;
                else
                {
                    if (len > 0) min = Math.Min(len, min);
                    len = 0;
                }
            }
            if (len > 0) min = Math.Min(len, min);
            Console.WriteLine("минимальная длина: " + min);
        }
    }
}
