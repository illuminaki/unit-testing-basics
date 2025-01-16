namespace UnitTestingBasics // Declares the namespace.
{
    public class Calculator // Class for performing mathematical operations.
    {
        /// <summary>
        /// Method to add two numbers.
        /// </summary>
        /// <param name="a">First number.</param>
        /// <param name="b">Second number.</param>
        /// <returns>The sum of both numbers.</returns>
        public int Add(int a, int b)
        {
            return a + b; // Returns the sum.
        }

        /// <summary>
        /// Method to subtract two numbers.
        /// </summary>
        /// <param name="a">First number.</param>
        /// <param name="b">Second number.</param>
        /// <returns>The result of subtracting b from a.</returns>
        public int Subtract(int a, int b)
        {
            return a - b; // Returns the difference.
        }

        /// <summary>
        /// Duplicate of Add method.
        /// </summary>
        /// <param name="a">First number.</param>
        /// <param name="b">Second number.</param>
        /// <returns>The sum of both numbers.</returns>
        public int AddDuplicate(int a, int b)
        {
            return a + b; // Duplicate logic.
        }

        /// <summary>
        /// Duplicate of Subtract method.
        /// </summary>
        /// <param name="a">First number.</param>
        /// <param name="b">Second number.</param>
        /// <returns>The result of subtracting b from a.</returns>
        public int SubtractDuplicate(int a, int b)
        {
            return a - b; // Duplicate logic.
        }
    }
}
