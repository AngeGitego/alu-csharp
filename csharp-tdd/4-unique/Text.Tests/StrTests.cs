using NUnit.Framework;
using Text;  // This should reference the Text project



namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void TestUniqueChar_WithUniqueCharacter_ReturnsCorrectIndex()
        {
            // Test when the string has a unique character
            string input = "aabbc";
            int result = Str.UniqueChar(input);
            Assert.AreEqual(4, result);  // 'c' is the first unique character at index 4
        }

        [Test]
        public void TestUniqueChar_NoUniqueCharacter_ReturnsMinusOne()
        {
            // Test when the string has no unique characters
            string input = "aabbcc";
            int result = Str.UniqueChar(input);
            Assert.AreEqual(-1, result);  // No unique character, should return -1
        }

        [Test]
        public void TestUniqueChar_EmptyString_ReturnsMinusOne()
        {
            // Test when the string is empty
            string input = "";
            int result = Str.UniqueChar(input);
            Assert.AreEqual(-1, result);  // No unique character in an empty string, should return -1
        }

        [Test]
        public void TestUniqueChar_SingleCharacter_ReturnsZero()
        {
            // Test when the string has only one character
            string input = "a";
            int result = Str.UniqueChar(input);
            Assert.AreEqual(0, result);  // 'a' is unique and at index 0
        }

        [Test]
        public void TestUniqueChar_MultipleUniqueCharacters_ReturnsFirstUniqueIndex()
        {
            // Test when the string has multiple unique characters
            string input = "abcabc";
            int result = Str.UniqueChar(input);
            Assert.AreEqual(0, result);  // 'a' is the first unique character at index 0
        }
    }
}
