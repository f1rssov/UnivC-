namespace VUZWorks6;

static class Factor
{
    public static void Main()
    {
        int.TryParse(Console.ReadLine(), out int num);

        int k, f;

        for (k = 1, f = 1; f < num; k++, f *= k) { }

        Console.WriteLine($"Факториал: {f}, число k: {k}");
    }
}