using System.Linq;
using System;

static class MaxNum
{
    public static void Main()
    {
        int[] nums = new int[5];
        int i = 0;
        while (i <= 4)
        {
            nums[i] = int.Parse(Console.ReadLine());
            i++;
        }
        Console.WriteLine($"{Enumerable.Max(nums)} - наибольшее число");
        Console.WriteLine($"{Enumerable.Min(nums)} - наименьшее число");
    }
}