//Проверка на простое число, до 0
using System;

class PrimeNumbers
{
    public static void Main()
    {
        int	i;
        int j;
        
        i = int.Parse(Console.ReadLine());
        while (i != 0)
        {
            j = 2;
            while (j < i)
            {
            	if (i % j == 0)
            	{
            		Console.WriteLine($"Число {i} составное");
            		break ;
            	}
            	j++;
            }
            if (j == i)
                Console.WriteLine($"Число {i} простое");
            i = int.Parse(Console.ReadLine());
        }
    }
}