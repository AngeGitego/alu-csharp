using NUnit.Framework;
using MyMath;
using System;

namespace MyMath.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        [Test]
        public void Divide_ValidMatrix_ReturnsCorrectResult()
        {
            int[,] matrix = { { 10, 20 }, { 30, 40 } };
            int[,] expected = { { 5, 10 }, { 15, 20 } };

            int[,]? result = Matrix.Divide(matrix, 2);
            
            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_ByZero_ReturnsNullAndPrintsMessage()
        {
            int[,] matrix = { { 10, 20 }, { 30, 40 } };

            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                int[,]? result = Matrix.Divide(matrix, 0);
                string output = sw.ToString().Trim();

                Assert.That(result, Is.Null);
                Assert.That(output, Is.EqualTo("Num cannot be 0"));
            }
        }

        [Test]
        public void Divide_NullMatrix_ReturnsNull()
        {
            int[,]? result = Matrix.Divide(null, 2);
            Assert.That(result, Is.Null);
        }

        [Test]
        public void Divide_MatrixWithNegativeNumbers_ReturnsCorrectResult()
        {
            int[,] matrix = { { -10, -20 }, { -30, -40 } };
            int[,] expected = { { -5, -10 }, { -15, -20 } };

            int[,]? result = Matrix.Divide(matrix, 2);

            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_MatrixWithMixedNumbers_ReturnsCorrectResult()
        {
            int[,] matrix = { { -10, 20 }, { 30, -40 } };
            int[,] expected = { { -5, 10 }, { 15, -20 } };

            int[,]? result = Matrix.Divide(matrix, 2);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
