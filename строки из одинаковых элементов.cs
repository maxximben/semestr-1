using System;

namespace CSharp
{
    internal class Program
    {
        static int[,] array(int m, int n)
        {
            Console.WriteLine("введи элементы массива:");
            int[,] arr = new int[m, n];
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) { 
                    arr[i, j] = Int32.Parse(Console.ReadLine());
                }
            } return arr;
        }

        static void print_array(int[,] arr, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                Console.Write($"#{i}\t");
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{arr[i, j]}\t" );
                }
                Console.WriteLine();
            }
        }
        static void pairs_of_strings(int[,] arr, int m, int n) { 
            int[,] products_and_zeros = new int[m, 2];
            for (int i = 0; i < m; i++)
            {
                int product = 1;
                int count_0 = 0;
                
                for (int j = 0; j < n; j++)
                {
                    if (arr[i, j] != 0)
                    product *= arr[i, j];
                    if (arr[i, j] == 0)
                    count_0++;
                }
                products_and_zeros[i, 0] = product;
                products_and_zeros[i, 1] = count_0;
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (products_and_zeros[i, 0] == products_and_zeros[j, 0] && products_and_zeros[i, 1] == products_and_zeros[j, 1] && i != j && i < j)
                    {
                        Console.WriteLine($"строки, состоящие из одинаковых элементов: {i} и {j}");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("введи число сторк m:");
            int m = Int32.Parse(Console.ReadLine());
            Console.WriteLine("введи число столбцов n:");
            int n = Int32.Parse(Console.ReadLine());
            int[,] array1 = new int[m, n];
            array1 = array(m, n);
            print_array(array1, m, n);
            pairs_of_strings(array1 , m, n);
            Console.ReadKey();
        }
    }
}
