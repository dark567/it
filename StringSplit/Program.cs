using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            string t1 = "HumaClot Quattro; H2870040; 25.05.2018; 13:00:58; 222; Thrombin T.; 1; 111,2;s; void;void; void;void; void;void; void;void; OK; D7B1;";

            Char delimiter = ';';
            String[] substrings = t1.Split(delimiter);

            for (int i = 0; i < substrings.Length; i++)
            {
                Console.WriteLine($"{i} - {substrings[i]}");
            }

            Console.ReadLine();

        }
    }
}
