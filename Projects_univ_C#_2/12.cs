
static class PerfectNum
{
    public static void Main()
    {
        int.TryParse(Console.ReadLine(), out int N);
        int i = 1;
        int j = 0;
        int[] nums = new int[200];

        while(i < N)
        {
            if (N % i == 0)
            {
                nums[j] = i;
                j++;
            }
            i++;
        }
        if(nums.Sum() == N)
            Console.WriteLine($"Сумма делителей: {nums.Sum()}, число: {N}, YESсовершенное");
        else
            Console.WriteLine($"Сумма делителей: {nums.Sum()}, число: {N}, NOсовершенное:");
    }
}