using NUnit.Framework;
using Text; // Add this line to reference the Str class

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void TestIsPalindrome_WithPalindrome_ReturnsTrue()
        {
            string input = "Racecar";
            bool result = Str.IsPalindrome(input);
            Assert.IsTrue(result);  // 'Racecar' is a palindrome
        }

        [Test]
        public void TestIsPalindrome_WithNonPalindrome_ReturnsFalse()
        {
            string input = "Hello";
            bool result = Str.IsPalindrome(input);
            Assert.IsFalse(result);  // 'Hello' is not a palindrome
        }

        [Test]
        public void TestIsPalindrome_WithEmptyString_ReturnsTrue()
        {
            string input = "";
            bool result = Str.IsPalindrome(input);
            Assert.IsTrue(result);  // Empty string is considered a palindrome
        }

        [Test]
        public void TestIsPalindrome_WithStringWithSpacesAndPunctuation_ReturnsTrue()
        {
            string input = "A man, a plan, a canal: Panama.";
            bool result = Str.IsPalindrome(input);
            Assert.IsTrue(result);  // The string is a palindrome ignoring spaces and punctuation
        }

        [Test]
        public void TestIsPalindrome_WithStringWithSpaces_ReturnsTrue()
        {
            string input = " level ";
            bool result = Str.IsPalindrome(input);
            Assert.IsTrue(result);  // ' level ' is a palindrome ignoring spaces
        }
    }
}
