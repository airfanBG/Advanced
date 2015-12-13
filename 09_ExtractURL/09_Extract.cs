using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


    class Program
    {
        static void Main()
        {
            string text = "The site nakov.com can be access from"+
                " http://nakov.com or www.nakov.com. It has subdomains"+
                " like mail.nakov.com and svetlin.nakov.com."+
                " Please check http://blog.nakov.com for more information.";
            Regex replaced = new Regex(@"(http://|www.)\S+\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            foreach (var item in replaced.Matches(text))
            {
                Console.WriteLine(item);
            }


        }
    }

