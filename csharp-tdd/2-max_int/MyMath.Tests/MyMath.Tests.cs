using NUnit.Framework;
using System.Collections.Generic;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Max_WithPositiveNumbers_ReturnsMax()
        {
            List<int> numbers = new List<int> { 1, 3, 7, 2, 5 };
            Assert.That(Operations.Max(numbers), Is.EqualTo(7));
        }

        [Test]
        public void Max_WithNegativeNumbers_ReturnsMax()
        {
            List<int> numbers = new List<int> { -10, -3, -7, -2, -5 };
            Assert.That(Operations.Max(numbers), Is.EqualTo(-2));
        }

        [Test]
        public void Max_WithMixedNumbers_ReturnsMax()
        {
            List<int> numbers = new List<int> { -10, 3, 7, -2, 5 };
            Assert.That(Operations.Max(numbers), Is.EqualTo(7));
        }

        [Test]
        public void Max_WithEmptyList_ReturnsZero()
        {
            List<int> numbers = new List<int>();
            Assert.That(Operations.Max(numbers), Is.EqualTo(0));
        }

        [Test]
        public void Max_WithNullList_ReturnsZero()
        {
            Assert.That(Operations.Max(null), Is.EqualTo(0));
        }
    }
}
