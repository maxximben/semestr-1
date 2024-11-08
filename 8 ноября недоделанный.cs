using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static int[][] array (int n)
        {
            int[][] arr = new int[n][];
            for (int i = 0; i < n; i++)
            {
                Console.Write("введи размер строки " + (i+1) + ": ");
                int m = Int32.Parse(Console.ReadLine());
                arr[i] = new int[m];
                Console.WriteLine("введи элементы строки " + (i+1));
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
                
                for (int j = 0; j < arr[i].Length-1; j++)
                {

                    flag = arr[i][j] > arr[i][j + 1] ? true : false;
                }
                Console.WriteLine(i);
                Console.WriteLine(flag);
                
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
