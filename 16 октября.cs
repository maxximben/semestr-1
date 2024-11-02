using System;

namespace CSharp
{
    internal class Program
    {
        static int count_0(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    count++;
                }
            }
            return count;
        }
        static int proizvedenie(int[] array)
        {
            bool b = false;
            int p = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                    if (b == true) {
                        p = 1;
                    }
                    p *= array[i];
            }
            return p;
        }
        static int[] array(int n)
        {

            int[] arr = new int[n];
            Console.WriteLine("Введи элементы массива: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            return arr;

        }
        static int kratn_3(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 3 == 0)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Введи длину массива " + i);
                int n = Int32.Parse(Console.ReadLine());
                int[] Array = new int[n];
                Array = array(n);

                Console.Write("Количество кратных 3: ");
                Console.WriteLine(kratn_3(Array));
                Console.Write("Произведение нечётных элементов: ");
                Console.WriteLine(proizvedenie(Array));
                Console.Write("Количество нулевых элементов: ");
                Console.WriteLine(count_0(Array));
                Console.ReadKey();
            }
        }
    }
}
