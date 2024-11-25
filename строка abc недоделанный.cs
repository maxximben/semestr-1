using System;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int maxcount = 0;
            string str = Console.ReadLine();
            char[] array = str.ToCharArray();
            
            for (int i = 1; i < array.Length; i++) {
                
               
                if (array[i] == 'c' && array[i - 1] == 'b') {
                    count++;
                }
                else if (array[i] == 'b' && array[i - 1] == 'a')
                {
                    count++;
                }
                else if (array[i] == 'a' && array[i - 1] == 'c')
                {
                    count++;
                }
                else
                {
                    maxcount = Math.Max(count, maxcount);
                    count = 0;
                }
            }
            Console.WriteLine("maxcount: " + maxcount);
        }
    }
}
