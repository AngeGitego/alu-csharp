namespace MyMath
{
    /// <summary>
    /// Provides mathematical operations related to integer calculations.
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Adds two integers and returns the result.
        /// </summary>
        /// <param name="a">The first integer to add.</param>
        /// <param name="b">The second integer to add.</param>
        /// <returns>The sum of the two integers.</returns>
        public static int Add(int a, int b)
        {
            // The Add method simply returns the sum of a and b
            return a + b;
        }

        /// <summary>
        /// Subtracts the second integer from the first and returns the result.
        /// </summary>
        /// <param name="a">The first integer (minuend).</param>
        /// <param name="b">The second integer (subtrahend).</param>
        /// <returns>The difference between the two integers.</returns>
        public static int Subtract(int a, int b)
        {
            // The Subtract method returns the difference between a and b
            return a - b;
        }

        /// <summary>
        /// Multiplies two integers and returns the result.
        /// </summary>
        /// <param name="a">The first integer to multiply.</param>
        /// <param name="b">The second integer to multiply.</param>
        /// <returns>The product of the two integers.</returns>
        public static int Multiply(int a, int b)
        {
            // The Multiply method returns the product of a and b
            return a * b;
        }

        /// <summary>
        /// Divides the first integer by the second and returns the result.
        /// </summary>
        /// <param name="a">The numerator (the integer to be divided).</param>
        /// <param name="b">The denominator (the integer to divide by).</param>
        /// <returns>The quotient of the two integers.</returns>
        /// <exception cref="System.DivideByZeroException">Thrown when the denominator (b) is zero.</exception>
        public static double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new System.DivideByZeroException("Cannot divide by zero.");
            }
            // The Divide method returns the quotient of a and b as a double
            return (double)a / b;
        }
    }
}
