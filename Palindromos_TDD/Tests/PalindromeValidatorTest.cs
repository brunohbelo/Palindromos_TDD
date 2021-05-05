using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Palindromos_TDD.Tests
{
    public static class PalindromeValidatorTest
    {

        [Fact]
        public static void IsPalindromeShouldNotAcceptNull()
        {
            //Arrange
            string palindrome = null;

            //Act
            var wordIsPalindrome = PalindromeValidator.IsPalindrome(palindrome);

            //Assert
            Assert.False(wordIsPalindrome);
        }

        [Fact]
        public static void IsPalindromeShouldNotAcceptOnlySpaces()
        {
            //Arrange
            string palindrome = "   ";

            //Act
            var wordIsPalindrome = PalindromeValidator.IsPalindrome(palindrome);

            //Assert
            Assert.False(wordIsPalindrome);
        }

        [Fact]
        public static void IsPalindromeShouldBeFalse()
        {
            //Arrange
            string palindrome = "xyz";

            //Act
            var wordIsPalindrome = PalindromeValidator.IsPalindrome(palindrome);

            //Assert
            Assert.False(wordIsPalindrome);
        }

        [Fact]
        public static void IsPalindromeShouldBeTrue()
        {
            //Arrange
            string palindrome = "madam";

            //Act
            var wordIsPalindrome = PalindromeValidator.IsPalindrome(palindrome);

            //Assert
            Assert.True(wordIsPalindrome);
        }


    }
}
