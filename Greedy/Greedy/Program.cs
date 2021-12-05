using System;

namespace Greedy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter price: ");
            var price = double.Parse(Console.ReadLine());
            int[] values = new int[6];

            while (price != 0)
            {
                if (price - 50 >= 0)
                {
                    price -= 50;
                    values[0]++;
                }
                else if (price - 20 >= 0)
                {
                    price -= 20;
                    values[1]++;
                }
                else if (price - 10 >= 0)
                {
                    price -= 10;
                    values[2]++;
                }
                else if (price - 5 >= 0)
                {
                    price -= 5;
                    values[3]++;
                }
                else if (price - 2 >= 0)
                {
                    price -= 2;
                    values[4]++;
                }
                else if (price - 1 >= 0)
                {
                    price -= 1;
                    values[5]++;
                }
            }
            Console.WriteLine($"50 pennies: {values[0]}");
            Console.WriteLine($"20 pennies: {values[1]}");
            Console.WriteLine($"10 pennies: {values[2]}");
            Console.WriteLine($"5 pennies: {values[3]}");
            Console.WriteLine($"2 pennies: {values[4]}");
            Console.WriteLine($"1 pennies: {values[5]}");
        }
    }
}
