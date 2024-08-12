//кратно или нет

using System;

static class Dividing
{
    public static void Main()
    {
        int v;
        
        v = 1;
        while (v == 1)
        {
            Console.Write("Введите первое число: ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int i1 = int.Parse(Console.ReadLine());
            if (i % i1 == 0)
                Console.WriteLine($"{i} кратно {i1}");
            if (i % i1 != 0)
                Console.WriteLine($"{i} некратно {i1}");
        }
    }
}