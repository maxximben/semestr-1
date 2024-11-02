using System;
/*Дан массив из n элементов, состоящий из переменных целого типа
1. Определить все ли элементы расположены в порядке возрастания
2. Определить количество элементов, значение которых оканчивается на 3
3. Для каждого элемента найти сумму цифр
4. Определить среднее арифметическое чётных элементов массива*/

namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи n: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("введи элементы массива:");
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = Int32.Parse(Console.ReadLine());
            }
            bool incr = increase(array);
            if (increase(array)) {
                Console.WriteLine("все элементы расположены в порядке возрастания");
            } else {
                Console.WriteLine("элементы не расположены в порядке возрастания");
            }
            Console.WriteLine("количество элементов, оканцивающхся на тройку: " + count_3(array));
            Console.WriteLine("суммы цифр элементов: " + string.Join(" ", sum_of_nums(array)));
            Console.ReadKey();
            
        }

        static bool increase(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++) {
                if (array[i] > array[i + 1]) { 
                    return false;
                }
            }
            return true;
        }

        static int count_3(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 10 == 3)
                {
                    count++;
                }
            }
            return count;
        }

        static int[] sum_of_nums(int[] array)
        {
            int[] sum = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                int n = array[i];
                while (n > 0) {
                    sum[i] += n % 10;
                    n /= 10;
                }
            }
            return sum;
        }
    }
}
