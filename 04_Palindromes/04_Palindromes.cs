using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstWord = 'a';
            
            int row = 3;
            int col = 6;
            int[,] matrix = new int[row, col];
            for (char i='a'; i <=firstWord+row-1; i++)
            {
                for (char j = i; j <i+col ; j++)
                {
                    string letters = i.ToString() + j.ToString() + i.ToString();
                    Console.Write(" "+letters);
                }
                Console.WriteLine();
                
            }
        }
    }
}
