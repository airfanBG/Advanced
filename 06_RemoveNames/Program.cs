using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RemoveNames
{
    class RemoveNames
    {
        static void Main()
        {
            List<string> namesOne = new List<string>();
            string[] firstNames = Console.ReadLine().Split();
            for (int i = 0; i < firstNames.Length; i++)
            {
                namesOne.Add(firstNames[i]);
                
            }
            List<string> namesTwo = new List<string>();
            string[] secondNames = Console.ReadLine().Split();
            for (int i = 0; i < secondNames.Length; i++)
            {
                namesTwo.Add(secondNames[i]);

            }
            List<string> all = new List<string>();
            foreach (var item in namesOne)
            {
                if (namesTwo.Contains(item))
                {
                    continue;
                }
                else
                {
                    all.Add(item);
                }
            }
                foreach (var item in all)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }

