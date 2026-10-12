using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDLGT_Buoi01_33254020126
{
    internal class Bai3
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập các phần tử của mảng (cách nhau bởi khoảng trắng): ");
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input)) return;


            int[] arr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                             .Select(int.Parse)
                             .ToArray();

            Console.WriteLine("\n================ KẾT QUẢ ================");


            Stopwatch swA = Stopwatch.StartNew();
            long maxSumA = MaxSubarraySum_VersionA(arr);
            swA.Stop();

            Console.WriteLine($"[Phiên bản A - O(n^2)]   Tổng lớn nhất: {maxSumA} | Thời gian: {swA.Elapsed.TotalMilliseconds:F4} ms");


            Stopwatch swB = Stopwatch.StartNew();
            long maxSumB = MaxSubarraySum_VersionB(arr);
            swB.Stop();

            Console.WriteLine($"[Phiên bản B - Kadane O(n)] Tổng lớn nhất: {maxSumB} | Thời gian: {swB.Elapsed.TotalMilliseconds:F4} ms");
        }

        static long MaxSubarraySum_VersionA(int[] a)
        {
            long maxSum = long.MinValue;
            int n = a.Length;

            for (int i = 0; i < n; i++)
            {
                long currentSum = 0;
                for (int j = i; j < n; j++)
                {
                    currentSum += a[j];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }

            return maxSum;
        }

        static long MaxSubarraySum_VersionB(int[] a)
        {
            long maxCurrent = a[0];
            long maxGlobal = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                maxCurrent = Math.Max((long)a[i], maxCurrent + a[i]);


                if (maxCurrent > maxGlobal)
                {
                    maxGlobal = maxCurrent;
                }
            }

            return maxGlobal;
        }
    }
}
