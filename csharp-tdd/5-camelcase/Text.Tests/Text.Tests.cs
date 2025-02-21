using NUnit.Framework;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void CamelCase_EmptyString_ReturnsZero()
        {
            var result = Str.CamelCase("");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void CamelCase_SingleWord_ReturnsOne()
        {
            var result = Str.CamelCase("word");
            Assert.AreEqual(1, result);
        }

        [Test]
        public void CamelCase_MultipleWords_ReturnsCorrectCount()
        {
            var result = Str.CamelCase("camelCaseStringTest");
            Assert.AreEqual(4, result);
        }

        [Test]
        public void CamelCase_WithEmptyWords_ReturnsCorrectCount()
        {
            var result = Str.CamelCase("oneCamelCaseWord");
            Assert.AreEqual(2, result);
        }
    }
}
