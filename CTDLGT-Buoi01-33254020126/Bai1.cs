using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDLGT_Buoi01_33254020126
{
    internal class Bai1
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập 3 số nguyên a, b, c (cách nhau bởi khoảng trắng): ");

            string input = Console.ReadLine();
            string[] parts = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length < 3)
            {
                Console.WriteLine("Vui lòng nhập đủ 3 số nguyên!");
                return;
            }

            int a = int.Parse(parts[0]);
            int b = int.Parse(parts[1]);
            int c = int.Parse(parts[2]);

            int max = Math.Max(a, Math.Max(b, c));
            int min = Math.Min(a, Math.Min(b, c));
            int sum = a + b + c;
            double average = (double)sum / 3;

            Console.WriteLine($"Lớn nhất: {max}; Nhỏ nhất: {min}; Tổng: {sum}; Trung bình: {average:0.##}");
        }
    }
}
