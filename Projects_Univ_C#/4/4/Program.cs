using System;

static class BigBank
{
    public static void Main()
    {
        int year = 0;
        double DaphnaBalance = 100;
        double CleoBalance = 100;

        while (CleoBalance <= DaphnaBalance)
        {
            year++;
            DaphnaBalance += 100 * 0.1;
            CleoBalance += CleoBalance * 0.05;
            Console.WriteLine($"{year} год:\t Баланс Дафны = {DaphnaBalance}");
            Console.WriteLine($"{year} год:\t Баланс Клео = {Math.Round(CleoBalance, 2)}");
        }
        Console.WriteLine($"Итоговый баланс Дафны: {DaphnaBalance}");
        Console.WriteLine($"Итоговый баланс Клео:{Math.Round(CleoBalance, 2)}");
        Console.WriteLine($"Прошло лет: {year}");
    }
}