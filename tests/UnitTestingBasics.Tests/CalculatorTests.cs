using Xunit; // Testing framework.
using UnitTestingBasics; // Reference to the main project.

namespace UnitTestingBasics.Tests // Test namespace.
{
    public class CalculatorTests // Test class for Calculator.
    {
        [Fact]
        public void Add_ReturnsCorrectSum() // Test for Add method.
        {
            // Arrange
            var calculator = new Calculator();
            int number1 = 2;
            int number2 = 3;

            // Act
            var result = calculator.Add(number1, number2);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Subtract_ReturnsCorrectDifference() // Test for Subtract method.
        {
            // Arrange
            var calculator = new Calculator();
            int number1 = 10;
            int number2 = 5;

            // Act
            var result = calculator.Subtract(number1, number2);

            // Assert
            Assert.Equal(5, result); // Verifies the difference.
        }

        [Theory] // Multiple test cases for Subtract method.
        [InlineData(10, 5, 5)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, -5, 0)]
        [InlineData(7, 3, 4)]
        [InlineData(3, 7, -4)]
        public void Subtract_ReturnsCorrectDifference_MultipleCases(int a, int b, int expected)
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = calculator.Subtract(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        // ------------------------------
        // Tests for AddDuplicate method
        // ------------------------------
        [Fact]
        public void AddDuplicate_ReturnsCorrectSum() // Single test for AddDuplicate method.
        {
            // Arrange
            var calculator = new Calculator();
            int number1 = 2;
            int number2 = 3;

            // Act
            var result = calculator.AddDuplicate(number1, number2);

            // Assert
            Assert.Equal(5, result);
        }

        [Theory] // Multiple test cases for AddDuplicate method.
        [InlineData(1, 1, 2)]
        [InlineData(0, 0, 0)]
        [InlineData(-2, -3, -5)]
        [InlineData(100, 50, 150)]
        public void AddDuplicate_ReturnsCorrectSum_MultipleCases(int a, int b, int expected)
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = calculator.AddDuplicate(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        // ---------------------------------
        // Tests for SubtractDuplicate method
        // ---------------------------------
        [Fact]
        public void SubtractDuplicate_ReturnsCorrectDifference() // Single test for SubtractDuplicate method.
        {
            // Arrange
            var calculator = new Calculator();
            int number1 = 10;
            int number2 = 5;

            // Act
            var result = calculator.SubtractDuplicate(number1, number2);

            // Assert
            Assert.Equal(5, result);
        }

        [Theory] // Multiple test cases for SubtractDuplicate method.
        [InlineData(10, 5, 5)]
        [InlineData(5, 10, -5)]
        [InlineData(0, 0, 0)]
        [InlineData(-2, -2, 0)]
        [InlineData(-5, 3, -8)]
        public void SubtractDuplicate_ReturnsCorrectDifference_MultipleCases(int a, int b, int expected)
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = calculator.SubtractDuplicate(a, b);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
