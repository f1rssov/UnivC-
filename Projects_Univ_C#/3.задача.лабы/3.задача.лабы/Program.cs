
static class Chetnost
{
    public static void Main()
    {
        int[] a = new int[3];
        for (int i = 0; i < 3; i++) int.TryParse(Console.ReadLine(), out a[i]);

        int[] chetnosty = { a[0] % 2, a[1] % 2, a[2] % 2 };
        int countOfZero = 0;

        foreach (var item in chetnosty) if (item == 0) countOfZero++;

        if ((countOfZero == 0) || (countOfZero == 3)) Console.WriteLine("ДА");
        else Console.WriteLine("НЕТ");
    }
}