using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Program
    {
        static void exchange(int[,] array, int m, int n){
            int max_i = 0;
            int min_i = 0;
            int max_number = -9000000;
            int min_number = 9000000;

   

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    
                    if (array[i, j] > max_number)
                    {
                        max_number = array[i, j];
                        max_i = i; 
                    }
                    
                    
                    if (array[i, j] < min_number)
                    {
                        min_number = array[i, j];
                        min_i = i; 
                    }

                    
                }
            }

            Console.WriteLine(max_number);
            Console.WriteLine(max_i);
            
            Console.WriteLine(min_number);
            Console.WriteLine(min_i);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    
                  
                }
            }
            
            
            



        }
        static void Main(string[] args)
        {
            Console.Write("введи количество строк массива: ");
            int m = Int32.Parse(Console.ReadLine());
            Console.Write("введи количество столбцов массива: ");
            int n = Int32.Parse(Console.ReadLine());

            int[,] array = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i,j] = Int32.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
            exchange(array, m, n);
            
            Console.ReadKey();

        }
    }
}
