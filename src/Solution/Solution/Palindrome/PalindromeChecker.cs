using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Solution.Palindrome
{






   

    public static class PalindromeChecker
    {
        public static bool CekPalindrom(string input)
        {
            if (string.IsNullOrEmpty(input)) return true;

            
            string normalized = Regex.Replace(input.ToLower(), "[^a-z0-9]", "");

            Stack<char> stack = new Stack<char>();
            foreach (char c in normalized)
            {
                stack.Push(c);
            }

            foreach (char c in normalized)
            {
                if (stack.Pop() != c)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
