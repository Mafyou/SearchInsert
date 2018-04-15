using System;
using System.Linq;

namespace SearchInsert
{
    class Program
    {
        /// <summary>
        /// Given a sorted array and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
        /// You may assume no duplicates in the array.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int SearchInsert(int[] nums, int target)
        {
            if (nums.Contains(target)) return Array.IndexOf(nums, target);
            foreach (int num in nums)
            {
                if (num > target) return Array.IndexOf(nums, num);
            }
            return nums.Length;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(new Program().SearchInsert(new int[] { 1, 3, 5, 6 }, 5)); // 2
            Console.WriteLine(new Program().SearchInsert(new int[] { 1, 3, 5, 6 }, 2)); // 1
            Console.WriteLine(new Program().SearchInsert(new int[] { 1, 3, 5, 6 }, 7)); // 4
            Console.WriteLine(new Program().SearchInsert(new int[] { 1, 3, 5, 6 }, 0)); // 0
            Console.ReadLine();
        }
    }
}