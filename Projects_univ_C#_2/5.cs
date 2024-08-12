namespace VUZWorks5;

static class Dividing
{
    public static void Main()
    {
        int.TryParse(Console.ReadLine(), out int num);
        var dividers = new List<int>();

        for (int i = num; i > (int) Math.Sqrt(num) - 1; i--)
        {
            if (num % i == 0)
            {
                dividers.Add(i);
                dividers.Add(num / i);
            }
        }

        while (true)
        {
            bool flag = true;
            for (int i = 0; i < dividers.Count - 1; i++)
                if (dividers[i] < dividers[i + 1])
                {
                    (dividers[i], dividers[i + 1]) = (dividers[i + 1], dividers[i]);
                    flag = false;
                }
            if (flag) break;
        }
        
        foreach (var item in dividers) Console.WriteLine($"{item} ");
    }
}