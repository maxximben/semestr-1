using System;

namespace CSharp
{
    internal class Program
    {
        static double[] double_array(string[] array)
        {
            double[] doubleArray = new double[array.Length];
            for (int i = 0; i < array.Length; i++) {
                doubleArray[i] = Convert.ToDouble(array[i]);
            }
            return doubleArray;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Скопируйте весь текст в файле и вставьте ниже: ");
            int n = Int32.Parse(Console.ReadLine());
            double min_cost = Double.MaxValue;
            int company = 0;

            double x1, y1, z1;
            double x2, y2, z2;
            double capacity1, capacity2;
            double square1, square2;
            double price1, price2;
            double price_per_liter1, price_per_liter2;
            double milk_cost;

            for (int i = 0; i < n; i++) {
                string values_str = Console.ReadLine().Replace('.', ',');
                string[] values_str_array = values_str.Split(' ');
                double[] values = double_array(values_str_array);

                x1 = values[0]; y1 = values[1]; z1 = values[2];
                x2 = values[3]; y2 = values[4]; z2 = values[5];
                price1 = values[6]; price2 = values[7];

                capacity1 = x1 * y1 * z1 * 0.001;
                capacity2 = x2 * y2 * z2 * 0.001;
                square1 = (x1 * y1 + x1 * z1 + y1 * z1) * 2;
                square2 = (x2 * y2 + x2 * z2 + y2 * z2) * 2;

                price_per_liter1 = price1 / capacity1;
                price_per_liter2 = price2 / capacity2;

                milk_cost = (square1 * price2 - price1 * square2) / (capacity2 * square1 - capacity1 * square2);

                if (milk_cost < min_cost)
                {
                    min_cost = milk_cost;
                    company = i + 1;
                }
            }

            min_cost = Math.Round(min_cost, 2);
            Console.Write("\n" + "Ответ: " +company + " ");
            Console.WriteLine(min_cost);
            Console.ReadKey();
            
        }
    }
}
