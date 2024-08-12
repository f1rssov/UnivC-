//Ввод чисел от 1 до 10, каждое число до веденного возводится в степень ввденного числа

using System.Linq;
using System;

static class Power
{
    public static void Main()
    {
        int inp;
        int i;

        inp = int.Parse(Console.ReadLine());
        while (inp >= 1 && inp <= 10)
        {
            i = 1;
            while(i <= inp)
            {
                var nums = string.Join(" ", Enumerable.Range(1, inp).Select(num => Math.Pow(num,i)));
                Console.WriteLine($"Числа в {i} степени: {nums}");
                i++;
            }
            inp = int.Parse(Console.ReadLine());
        }
    }
}