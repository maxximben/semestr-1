// ������ � ��������
using System;
namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("l=3, m=3, k=5");
            int l, m, k;
            l = 3; m = 3; k = 5;

            Console.Write("������� n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int s = (k * 2 + l * (n + 1) + m * 2) * n;

            Console.WriteLine("����������: " + s);

            Console.ReadKey();
        }
    }
}