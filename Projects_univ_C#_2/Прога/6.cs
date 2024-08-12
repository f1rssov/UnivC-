//Сортировка строки Цифры-Буквы-Символы
using System;
using System.Linq;


static class Work
{
     private static readonly Random Rand = new();

    private static string SelectSymbols(string @string, Func<char, bool> check, bool flag = true) =>
        @string.Where(x => check.Invoke(x) && flag)
            .Select(x => x.ToString())
            .Aggregate((x, y) => x + y);

    public static void Main()
    {
        var strlen = 201;
        string str = "";
        int i = 0;

        while (i < strlen)
        {
            str += (char)Rand.Next(33, 126);
            i++;
        }
        Console.WriteLine(str + "\n");

        var digits = SelectSymbols(str, char.IsDigit);
        var letters = SelectSymbols(str, char.IsLetter);
        var symbols = SelectSymbols(str, char.IsLetterOrDigit, false) ?? "";

        var result = string.Concat(digits, letters, symbols);
        Console.WriteLine(result);
    }

}