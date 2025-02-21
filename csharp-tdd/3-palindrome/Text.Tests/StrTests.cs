using NUnit.Framework;
using Text;  // Make sure this namespace is correct

namespace Text.Tests
{
    public class StrTests
    {
        [Test]
        public void TestIsPalindrome()
        {
            Assert.IsTrue(Str.IsPalindrome("A man, a plan, a canal: Panama"));
        }

        [Test]
        public void TestIsPalindromeWithNonPalindrome()
        {
            Assert.IsFalse(Str.IsPalindrome("hello"));
        }

        [Test]
        public void TestEmptyStringIsPalindrome()
        {
            Assert.IsTrue(Str.IsPalindrome(""));
        }

        [Test]
        public void TestSingleCharacterIsPalindrome()
        {
            Assert.IsTrue(Str.IsPalindrome("a"));
        }
    }
}
