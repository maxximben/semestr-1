using System;

namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Скопируйте весь текст в файле и вставьте ниже: ");
            string m_n = Console.ReadLine();
            string[] m_n_arr = m_n.Split(' ');
            int m = Int32.Parse(m_n_arr[1]);
            int n = Int32.Parse(m_n_arr[0]);
            string xyz = Console.ReadLine();
            string[] xyz_arr = xyz.Split(' ');
            int x, y, z;
            x = Int32.Parse((xyz_arr[0]));
            y = Int32.Parse((xyz_arr[1]));
            z = Int32.Parse((xyz_arr[2]));

            int x0 = x;
            int y0 = y;
            int z0 = z;
            
            for (int i = 0; i < m; i++) {
                string aks = Console.ReadLine();
                string[] aks_arr = aks.Split(' ');
                string a = aks_arr[0];
                int k, s;
                k = Int32.Parse((aks_arr[1]));
                s = Int32.Parse((aks_arr[2]));

                if (a == "Z" && s == 1)
                {
                    if (k != z0) continue;
                    x = y0;
                    y = n - x0 + 1;
                }
                else if (a == "Z" && s == -1)
                {
                    if (k != z0) continue;
                    x = n - y0 + 1;
                    y = x0;
                }
                else if (a == "X" && s == 1)
                {
                    if (k != x0) continue;
                    y = z0;
                    z = n - y0 + 1;
                }
                else if (a == "X" && s == -1)
                {
                    if (k != x0) continue;
                    y = n - z0 + 1;
                    z = y0;
                }
                else if (a == "Y" && s == 1)
                {
                    if (k != y0) continue;
                    x = z0;
                    z = n - x0 + 1;
                }
                else if (a == "Y" && s == -1) 
                {
                    if (k != y0) continue;
                    x = n - z0 + 1;
                    z = x0;
                }
                x0 = x;
                y0 = y;
                z0 = z;
            }
            Console.WriteLine($"Ответ: {x} {y} {z}");
            Console.ReadKey();
        }
    }
}
