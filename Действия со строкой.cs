using System;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            
            string str = Console.ReadLine();
            while (str.Contains("  "))
            {
                str = str.Replace("  ", " ");
            }
            string[] words = str.Split(' ');
            Console.WriteLine(str);
            Console.WriteLine();
            Console.WriteLine("Палиндромы: ");
            for (int i = 0; i < words.Length; i++)
            {
                
                string s = words[i].ToLower();
                char[] array = s.ToCharArray(0, s.Length);
                Array.Reverse(array);

                string reversed = string.Join("", array);
                               
                if (s == reversed) Console.WriteLine(s);
                if (array[0] == array[array.Length-1]) count++;

            }
            Console.WriteLine("Количество слов, в которых первый символ совпадает с последним: " + count);
        }
    }
}
