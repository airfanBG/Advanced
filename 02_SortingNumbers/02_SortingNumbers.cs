using System;
using System.Collections.Concurrent;

class Program
{
   
    static void Main()
    {
        Console.WriteLine("Enter count of numbers");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter {0}th number",i+1);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] > numbers[j])
                {
                    int oldNUm = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = oldNUm;

                }
            }
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("{0}", numbers[i]);
            if (i < (numbers.Length - 1))
            {
                Console.Write(", ");
            }

        }
        Console.WriteLine();
    }

}


        