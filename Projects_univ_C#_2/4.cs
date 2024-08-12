namespace VUZWorks4;

static class Fibonacci
{
    public static void Main()
    {
        int.TryParse(Console.ReadLine(), out int num);

        int result = 0, sum = 0;
        int f1 = 0, f2 = 1;

        while (result < num)
        {
            result = f1 + f2;
            f1 = f2;
            f2 = result;
            sum += f1;
            if (f1 + f2 > num) break;
        }

        sum += result;

        Console.WriteLine(sum);
    }
}