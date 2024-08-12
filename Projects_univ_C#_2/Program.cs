namespace VuzWork2;

internal static class Program
{
    private static string CommandA(string input)
    {
        var words = input.Split(" ")
            .Select(x => x
                .Aggregate("", (current, t) => current + char.ToLower(t)))
            .OrderBy(x => x.First());

        return string.Concat(words.Select(x => x.Last()));
    }
    private static string CommandB(string input) =>
        string.Join(" ", input.Split(" ").Select(x => char.ToUpper(x[0]) +
                                                      string.Concat(x.Skip(1).SkipLast(1)) +
                                                      char.ToLower(x[^1])));

    private static int CommandC(string input)
    {
        Console.Write("Введите слово для поиска его частоты появления в строке: ");
        var word = Console.ReadLine()?.Aggregate("", (s, c) => s + char.ToLower(c));
        
        var words = input.Split(" ").Select(x => x.Aggregate("", (current, t) => current + char.ToLower(t)));

        return words.Count(x => x == word);
    }
    private static string CommandD(string input)
    {
        Console.Write("Введите слово для замены : ");
        var replacer = Console.ReadLine() ?? "Replacer is empty";
        
        var temp = input.Split(" ");
        temp[^1] = replacer;

        return string.Join(" ", temp);
    }
    private static string CommandE(string input) => 
        string.Join(" ", input.Split(" ").Where(x => char.IsUpper(x[0])));

    public static void Main()
    {
        var flag = true;
        while (flag)
        {
            Console.Write("Введите строку: ");
            var input = Console.ReadLine();

            Console.WriteLine("Выберите команду:\n" +
                              "A) Отсортировать строку по алфавиту и вывести слово, состоящее из последних символов этих слов\n" +
                              "B) В каждом слове строки поднять регистр первой буквы и опустить регистр последней буквы\n" +
                              "C) Подсчитать сколько раз в строке встречается заданное слово\n" +
                              "D) Заменить в строке последнее слово на заданное слово\n" +
                              "E) Найти в строке слово начинающееся с заглавной буквы\n" +
                              "0) Выйти из программы");
        
            Console.WriteLine("Нажмите кнопку соответствующую вашему выбору");
            var choice = Console.ReadKey().Key;
            Console.WriteLine();

            switch (choice)
            {
                case ConsoleKey.A:
                    Console.WriteLine(CommandA(input ?? "Input is empty"));
                    break;
                case ConsoleKey.B:
                    Console.WriteLine(CommandB(input ?? "Input is empty"));
                    break;
                case ConsoleKey.C:
                    Console.WriteLine(CommandC(input ?? "Input is empty"));
                    break;
                case ConsoleKey.D:
                    Console.WriteLine(CommandD(input ?? "Input is empty"));
                    break;
                case ConsoleKey.E:
                    Console.WriteLine(CommandE(input ?? "Input is empty"));
                    break;
                case ConsoleKey.D0:
                    flag = false;
                    break;
            }
        }
    }
}

