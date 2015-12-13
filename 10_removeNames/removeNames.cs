using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_removeNames
{
    class removeNames
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            string[] firstNames = Console.ReadLine().Split();
            for (int i = 0; i < firstNames.Length; i++)
            {
                names.Add(firstNames[i]);
            }
            List<string> names2 = new List<string>();
            string[] secondNames = Console.ReadLine().Split();
            for (int i = 0; i < secondNames.Length; i++)
            {
                names2.Add(secondNames[i]);

            }
            List<string> aggregate = new List<string>();
            foreach (var item in names)
            {
                if (names2.Contains(item)) 
                {
                    continue;
                }
                else
                {
                    aggregate.Add(item);
                }
                
            }
            foreach (var item in aggregate)
            {
                Console.WriteLine(item);
                
            }
            
            }
        }
    }

