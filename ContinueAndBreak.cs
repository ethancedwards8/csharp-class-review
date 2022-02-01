using System;
using System.Collections.Generic;

public class ConinueAndBreak
{
	public static void Main()
    {
        List<int> numbers = new List<int>();

        for (int i = 0; i <= 15; i++)
        {
            numbers.Add(i);
        }

        foreach(int j in numbers)
        {
            Console.WriteLine($"Current Number is: {j}");
        }
        Console.WriteLine("-------");
        foreach (int j in numbers)
        {
            if (j == 5)
            {
                continue;
            }
            else
            {
                Console.WriteLine($"Current Number is: {j}");
            }   
        }
        Console.WriteLine("-------");
        foreach (int j in numbers)
        {
            if (j == 5)
            {
                break;
            }
            else
            {
                Console.WriteLine($"Current Number is: {j}");
            }
        }
    }
}
