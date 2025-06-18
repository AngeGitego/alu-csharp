using NUnit.Framework;
using Text;  // Make sure this references the Text project containing Str class

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void TestUniqueChar_WithUniqueCharacter_ReturnsCorrectIndex()
        {
            string input = "aabbc";
            int result = Str.UniqueChar(input);
            Assert.AreEqual(4, result);  // 'c' is the first unique character at index 4
        }

        [Test]
        public void TestUniqueChar_NoUniqueCharacter_ReturnsMinusOne()
        {
            string input = "aabbcc";
            int result = Str.UniqueChar(input);
            Assert.AreEqual(-1, result);  // No unique character, should return -1
        }

        [Test]
        public void TestUniqueChar_EmptyString_ReturnsMinusOne()
        {
            string input = "";
            int result = Str.UniqueChar(input);
            Assert.AreEqual(-1, result);  // No unique character in an empty string, should return -1
        }

        [Test]
        public void TestUniqueChar_SingleCharacter_ReturnsZero()
        {
            string input = "a";
            int result = Str.UniqueChar(input);
            Assert.AreEqual(0, result);  // 'a' is unique and at index 0
        }

        [Test]
public void TestUniqueChar_MultipleUniqueCharacters_ReturnsFirstUniqueIndex()
{
    // Test when the string has multiple unique characters
    string input = "abccba"; // 'a' is the first unique character at index 0
    int result = Str.UniqueChar(input);
    Assert.AreEqual(-1, result);  // 'a' is the first unique character at index 0
}

    }
}
