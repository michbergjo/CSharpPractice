using System;
using PalindromeChecker;

namespace PalindromeChecker
{
    class TestPalindrome
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter an input string: ");

            string input = Console.ReadLine();

            bool isPalindrome = PalindromeChecker.CheckPalindrome(input, PalindromeChecker.reverse(input));

            if (isPalindrome)
            {
                Console.WriteLine("{0} is a Palindrome. It is {0} backwards and forwards", input);
            }
            else
            {
                Console.WriteLine("{0} is not a Palindrome. It is {0} forwards and {1} backwards",
                    input, PalindromeChecker.reverse(input));
            }
        }
    }
}
