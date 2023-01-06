using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Active12
{
    public class Program
    {
        public static void Main()
        {
            //string str;
            int i, wrd, l;


            //str = Console.ReadLine();
            string str = System.IO.File.ReadAllText("Input.txt");

            l = 1;
            wrd = 1;

            /* loop till end of string */
            while (l <= str.Length - 1)
            {
                /* check whether the current character is white space or new line or tab character*/
                if ((str[l] == '.' || str[l] == ' ' || str[l] == '\t' || str[l] == '!' || str[l] == ',' || str[l] == '?' || str[l] == '\n') && (str[l - 1] == 't' || str[l - 1] == 'e'))
                {
                    wrd++;
                }


                l++;
            }

            Console.Write("There are {0} words ending in t or e", wrd);
            Console.ReadLine();
        }
    }
}
