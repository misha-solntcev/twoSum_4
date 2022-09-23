using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Задача.
 Найти два числа из массива, в сумме равных числу к.
    Решение с помощью двух указателей.  */

namespace twoSum_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -9, -5, -2, -1, 1, 4, 9, 11 };
            int K = 3;
            int first = 0;
            int last = nums.Length - 1;
            int[] res= new int[] {0, 0};

            while (first < last)
            {
                int sum = nums[first] + nums[last];
                if (sum == K)                
                    res = new int[] { nums[first], nums[last] };                
                if (sum > K)
                    last--;
                else
                    first++;
            }
            Console.WriteLine($"[{res[0]}, {res[1]}]");
            Console.ReadKey();
        }
    }
}
