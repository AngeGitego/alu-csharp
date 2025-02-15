using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    /// <summary>
    /// Contains unit tests for the Operations class.
    /// </summary>
    public class OperationsTests
    {
        /// <summary>
        /// Tests the Add method for correct sum of two integers.
        /// </summary>
        [Test]
        public void Add_TwoNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = 5;
            int b = 10;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.AreEqual(15, result);
        }

        /// <summary>
        /// Tests the Add method for negative numbers.
        /// </summary>
        [Test]
        public void Add_NegativeNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = -5;
            int b = -10;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.AreEqual(-15, result);
        }
    }
}
