using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            Assert.AreEqual(5, Operations.Add(2, 3));
        }

        [Test]
        public void Add_PositiveAndNegativeNumbers_ReturnsCorrectSum()
        {
            Assert.AreEqual(1, Operations.Add(3, -2));
        }

        [Test]
        public void Add_TwoNegativeNumbers_ReturnsCorrectSum()
        {
            Assert.AreEqual(-5, Operations.Add(-2, -3));
        }

        [Test]
        public void Add_ZeroAndNumber_ReturnsSameNumber()
        {
            Assert.AreEqual(7, Operations.Add(0, 7));
            Assert.AreEqual(-4, Operations.Add(-4, 0));
        }
    }
}
