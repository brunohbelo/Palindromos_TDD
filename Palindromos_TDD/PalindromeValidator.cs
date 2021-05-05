using System;
using System.Collections.Generic;
using System.Text;

namespace Palindromos_TDD
{
    public static class PalindromeValidator
    {
        public static bool IsPalindrome(string palindrome)
        {
            if (string.IsNullOrEmpty(palindrome) || string.IsNullOrWhiteSpace(palindrome))
                return false;

            char[] letters = palindrome.ToCharArray();
            Array.Reverse(letters);
            var reversedPalindrome = new String(letters);

            var result = palindrome == reversedPalindrome;

            return result;
        }
    }
}
