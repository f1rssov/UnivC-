namespace VUZWorks9;

static class numSum
{
    public static void Main()
    {
        int.TryParse(Console.ReadLine(), out int n);

        var arrayN = n.ToString().Select(x => int.Parse(x.ToString())).ToArray();

        int sum = 0;

        for (int i = 0; i < arrayN.Length; i += 2) sum += arrayN[i];

        Console.WriteLine(sum);
    }
}