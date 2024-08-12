namespace VUZWorks7;

static class Odd35
{
    private static Random rand = new();

    public static void Main()
    {
        int[] nums = new int[100];
        for (int i = 0; i < nums.Length; i++) nums[i] = rand.Next(0, 500);

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

        Console.WriteLine($"Два наименьших элемента: {nums[0]} и {nums[1]}");
    }
}