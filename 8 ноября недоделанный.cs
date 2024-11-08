using System;
//определить номера строк, элементы которых образуют равномерно убывающую последовательность
namespace CSharp
{
    internal class Program
    {
        static int[][] array(int n)
        {
            int[][] arr = new int[n][];
            for (int i = 0; i < n; i++)
            {
                Console.Write("введи размер строки " + (i + 1) + " (как минимум 3): ");
                int m = Int32.Parse(Console.ReadLine());
                arr[i] = new int[m];
                Console.WriteLine("введи элементы строки " + (i + 1));
                for (int j = 0; j < m; j++)
                {
                    arr[i][j] = Int32.Parse(Console.ReadLine());
                }
            }
            return arr;
        }

        static void strings(int[][] arr)
        {
            Console.WriteLine("равномерно убывающие последовательности:");
            for (int i = 0; i < arr.Length; i++)
            {
                bool flag = true;
                bool flag2 = true;

                for (int j = 0; j < arr[i].Length - 1; j++)
                {
                    if (arr[i][j] <= arr[i][j + 1])
                        flag = false;
                }
                for (int j = 0; j < arr[i].Length-2; j++)
                {
                    if (arr[i][j] - arr[i][j + 1] != arr[i][j + 1] - arr[i][j + 2])
                        flag2 = false;
                }
                if (flag && flag2)
                {
                    Console.WriteLine(i+1);
                }
                
            }
        }


        static void Main(string[] args)
        {
            Console.Write("введи количество сторок: ");
            int n = Int32.Parse(Console.ReadLine());
            int[][] array1 = array(n);
            strings(array1);

            Console.ReadKey();
        }
    }
}
