
static class MaxMin
{
    private static Random rand = new();

    //Min search
    public static int Min(params int[] nums)
    {
        int min = int.MaxValue;
        foreach (var item in nums)
            if (item < min) min = item;
        return min;
    }
    //Max search
    public static int Max(params int[] nums)
    {
        int max = int.MinValue;
        foreach (var item in nums)
            if (item > max) max = item;
        return max;
    }

    public static void Main()
    {
        int[] a = new int[100];
        for (int i = 0; i < a.Length; i++) a[i] = rand.Next(0, 500);

        Console.Write("Массив: ");
        foreach (var item in a) Console.Write(item + ", ");
        Console.WriteLine();
        Console.WriteLine($"Минимальное: {Min(a)}");
        Console.WriteLine($"Максимальное: {Max(a)}");
    }
}

