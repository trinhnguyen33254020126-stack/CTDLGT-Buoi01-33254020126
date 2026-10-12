using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDLGT_Buoi01_33254020126
{
    internal class Bai2
    {
        static void Main()
        {
            if (!int.TryParse(Console.ReadLine(), out int n) || n < 2 || n > 100000)
            {
                return;
            }

            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input)) return;

            string[] parts = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            long? max1 = null;
            long? max2 = null;


            for (int i = 0; i < n && i < parts.Length; i++)
            {
                long x = long.Parse(parts[i]);

                if (max1 == null || x > max1)
                {
                    max2 = max1;
                    max1 = x;
                }
                else if (x < max1 && (max2 == null || x > max2))
                {
                    max2 = x;
                }
            }


            if (max2.HasValue)
            {
                Console.WriteLine($"{max1} {max2}");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
