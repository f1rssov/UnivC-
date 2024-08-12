
static class DateNums
{
    public static void Main()
    {
        int.TryParse(Console.ReadLine(), out int day);
        int dayNumSum = day.ToString().Select(x => int.Parse(x.ToString())).Sum();
        int.TryParse(Console.ReadLine(), out int month);
        int monthNumSum = month.ToString().Select(x => int.Parse(x.ToString())).Sum();

        int currentYear = 2022;
        int yearNumSum = currentYear.ToString().Select(x => int.Parse(x.ToString())).Sum();

        while (yearNumSum % 10 != dayNumSum % 10 && yearNumSum % 10 != monthNumSum % 10)
        {
            currentYear++;
            yearNumSum = currentYear.ToString().Select(x => int.Parse(x.ToString())).Sum();
        }

        Console.WriteLine($"Счастливый год: {currentYear}\n" +
                          $"Остаток от деления на 10 года: {yearNumSum % 10}\n" +
                          $"Остаток от деления на 10 дня: {dayNumSum % 10}\n" +
                          $"Остаток от деления на 10 месяца: {monthNumSum % 10}");

    }
}