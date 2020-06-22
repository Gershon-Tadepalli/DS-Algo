using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_AlgoLibrary.Strings
{
    public class ReverseAString
    {
        public void ReverseString(char[] s)
        {
            if(s.Length!=0)
            {
                int low = 0, high = s.Length - 1;
                char c;
                while (low<high)
                {
                    if(low!=high)
                    {
                        c = s[low];
                        s[low] = s[high];
                        s[high] = c;
                        low++;
                        high--;
                    }
                }
                Console.WriteLine("Reverse of a string :");
                for (int i = 0; i < s.Length; i++)
                {
                    Console.Write($"{s[i]} ");
                }
                Console.WriteLine();
            }
        }
        }
}
