//перевернуть число и удалить нечётные цифры
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            
            int last_digit;
            while (a > 0) 
            {
                a = Convert.ToInt32(Console.ReadLine());
                int p = a;
                int count_even = 0;
                while (p != 0)
                {
                    last_digit = p % 10;
                    if (last_digit % 2 == 0)
                        count_even++;
                    p /= 10;
                }
                if (count_even == 0)
                { Console.WriteLine("четных нет"); continue; }

                int s = 0;
                int n = a;
                int i = 1;
                while (n != 0)
                {
                    last_digit = n % 10;
                    if (last_digit % 2 == 0)
                        s = (s + last_digit) * 10;
                    n /= 10;
                }
                Console.WriteLine(s/10);
                Console.WriteLine();
            }
        }
    }
}
