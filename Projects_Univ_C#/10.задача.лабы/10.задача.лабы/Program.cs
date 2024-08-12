static class maxRazn
{
    private static Random rand = new Random();

    public static void Main()
    {
        int[] nums = new int[75];
        for (int i = 0; i < nums.Length; i++) nums[i] = rand.Next(-5, 20);

        foreach (var item in nums) Console.Write(item + ", ");
        Console.Write("\n");
        while (true)
        {
            bool flag = true;
            for (int i = 0; i < nums.Length - 1; i++)
                if (nums[i] > nums[i + 1])
                {
                    (nums[i], nums[i + 1]) = (nums[i + 1], nums[i]);
                    flag = false;
                }
            if (flag) break;
        }

        Console.WriteLine($"{nums[^1]} {nums[0]}");
        int razn = nums[^1] - nums[0];

        Console.WriteLine($"Максимальная разность: {razn}");
    }
}