using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split(new char[] { ',', ';', ' ', '-', '.' },
                StringSplitOptions.RemoveEmptyEntries);
            string maxWord = text[0];
            for (int i = 0; i < text.Length; i++)
            {
                if (maxWord.Length>text[i].Length)
                {
                    continue;
                }
                else
                {
                    maxWord = text[i];
                }
            }
                Console.WriteLine(maxWord);
            }
            
        }
    
