using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChecker
{
    class PalindromeChecker
    {
        public static string reverse(string input)
        {
            string output = "";

            if(input == null)
            {
                return "Invalid Input";
            }

            for(int i=input.Length-1; i >= 0; i--)
            {
                output += input[i].ToString();
            }

            return output;
        }

        public static bool CheckPalindrome(string input, string output)
        {
            if(input == output)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
