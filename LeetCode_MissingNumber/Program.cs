using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_MissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.MissingNumber(new int[] {0, 1, 2, 3, 4, 6}));
        }
    }
    public class Solution
    {
        public int MissingNumber(int[] nums)
        {
            var values = new bool[nums.Length + 1];

            foreach (var n in nums)
            {
                values[n] = true;
            }

            for (var i = 0; i < values.Length; i++)
            {
                if (!values[i]) return i;
            }

            return -1;
        }
    }
}
