
static class work2
{
    public static void Main()
    {
        for (int i = 90; i >= 5; i--)
            if ((i % 2 != 0) && (i % 3 == 0) && (i % 5 != 0)) Console.WriteLine(i);
    }
}