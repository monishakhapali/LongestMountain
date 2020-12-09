using System;

namespace LongestMountain
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] arr = { 2, 3, 1, 2, 3, 4, 5, 6 };
            LongestMountain(arr);
        }
        public static int LongestMountain(int[] arr)
        {
            bool flag = false;
            int res = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i;
                int count = 1;
                while (j < arr.Length && arr[j] > arr[j - 1])
                {
                    count++;
                    j++;
                }
                while (i != j && j < arr.Length && arr[j] < arr[j - 1])
                {
                    count++;
                    j++;
                    flag = true;
                }
                if (i != j && flag && count >= 3)
                {
                    res = Math.Max(res, count);
                    j--;
                }
                i = j;
            }
            return res;
        }
    }
}
