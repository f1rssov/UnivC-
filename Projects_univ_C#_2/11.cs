namespace VUZWorks11;

static class Students
{
    private static Random rand = new();

    public static void Main()
    {
        int[,] ROST = new int[70,2];
        for (int i = 0; i < 70; i++)
        {
            ROST[i, 0] = rand.Next(140, 220);
            ROST[i, 1] = i + 1;
        }

        int[,] NR = new int[70, 2];
        for (int i = 0; i < 70; i++)
        {
            if (ROST[i, 0] < 180)
            {
                NR[i, 0] = ROST[i, 0];
                NR[i, 1] = ROST[i, 1];
            }
        }

        int countOfLess180 = 0;
        for (int i = 0; i < 70; i++)
        {
            if (NR[i, 0] != 0) countOfLess180++;
        }

        Console.WriteLine(countOfLess180);
    }
}