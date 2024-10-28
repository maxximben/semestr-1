using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Program
    {  
        static void count(int[][] array){
            int sum = 0;

            for (int i = 0; i < array.Length; i++) {
                for (int j = 0; j < array[i].Length; j++) {
                    if (array[i][j] % 2 != 0) {
                        sum += 1;
                    }
                    
                }
                    Console.WriteLine("количество нечётных элементов " + (i+1) + " строки: " + sum);
                    sum = 0;
            }
            
        }

        static void Main(string[] args)
        {

            int n;
            int[][] array = new int[3][];
            for (int i = 0; i < 3; i++) {   
                Console.Write("введи количество элементов " + (i + 1) + " строки: ");
                n = Int32.Parse(Console.ReadLine());
                array[i] = new int[n];
                Console.WriteLine("введи элементы " + (i+1) + " строки");
                for (int j = 0; j < n; j++)
                {
                    array[i][j] = Int32.Parse(Console.ReadLine());
                }
            }
            count(array);
            Console.ReadKey();

        }
    }
}
