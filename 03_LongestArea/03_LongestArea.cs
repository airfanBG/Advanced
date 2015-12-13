using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string words = Console.ReadLine();
        string[] wordsSplit = words.Split();
        string [] wordsArray = new string [wordsSplit.Length];
        int count = 0;
        int maxSecuence=0;
        int index = 0;
        List<string> counted = new List<string>();
        for (int i = 0; i < wordsSplit.Length; i++)
			{
                wordsArray[i] = wordsSplit[i];
                
			}
        for (int i = 0; i <= wordsArray.Length-1; i++)
        {
            count=0;
            int j = 1;
            while (wordsArray[i] == wordsArray[j])
            {

                count++;
                j++;

                if (j>=wordsArray.Length)
                {
                    break; 
                }

            }
            if (count>maxSecuence)
            {
                maxSecuence = count;
                index = i;
            }
           
        }
        
        for (int i = index; i <= index+maxSecuence-1; i++)
        {
           
            if (i!=index+maxSecuence-1)
            {
                Console.WriteLine(maxSecuence);
                Console.WriteLine(wordsArray[i]);
                
            }

            else
            {
                
                    Console.WriteLine(maxSecuence);
                    Console.WriteLine(wordsArray[i]);
                }
            }
            
        }
        
       

        
        
        }







