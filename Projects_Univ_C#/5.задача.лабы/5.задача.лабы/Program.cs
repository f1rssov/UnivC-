static class Dividing
{
    public static void Main()
    {
        int n;
        int i;

        n = int.Parse(Console.ReadLine());
        i = n;
        while (i != 0)
        {
            if (n % i == 0)
                Console.WriteLine(i);
            i--;
        }
    }
}