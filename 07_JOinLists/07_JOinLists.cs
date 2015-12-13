using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {
            List<string> numbers = new List<string>();
            string[] firstNumbers = Console.ReadLine().Split();
            for (int i = 0; i < firstNumbers.Length; i++)
            {
                numbers.Add(firstNumbers[i]);
            }
            List<string> numbers1 = new List<string>();
            string[] secondNUmbers = Console.ReadLine().Split();
            for (int i = 0; i < secondNUmbers.Length; i++)
            {
                numbers.Add(secondNUmbers[i]);
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers1.Contains(numbers[i]))
                {
                    continue;
                }
                else
                {
                    numbers.Add(numbers1[i]);
                }
            }
            numbers.Sort();
            foreach (var item in numbers)
            {
                Console.Write(item+" ");
            }
            
        }
    }

