using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_AlgoLibrary.Strings
{
    public class Palindrome
    {
        public bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;
            int head = 0, tail = s.Length - 1;
            char chead, ctail;
            while (head<=tail)
            {
                chead = s[head];
                ctail = s[tail];
                if (!Char.IsLetterOrDigit(chead)) head++;
                else if (!Char.IsLetterOrDigit(ctail)) tail--;
                else
                {
                    if (Char.ToLower(chead) != Char.ToLower(ctail)) return false;

                    head++;
                    tail--;
                }
            }
            return true;
        }
    }
}
