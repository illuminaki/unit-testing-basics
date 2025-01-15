using Xunit; // Testing framework.
using UnitTestingBasics; // Reference to the main project.

namespace UnitTestingBasics.Tests // Test namespace.
{
    public class CalculatorTests // Test class for Calculator.
    {
        [Fact]
        public void Add_ReturnsCorrectSum() // Test method.
        {
            // AAA Pattern:
            // Arrange: Prepare test data.
            var calculator = new Calculator();
            int number1 = 2;
            int number2 = 3;

            // Act: Execute the method under test.
            var result = calculator.Add(number1, number2);

            // Assert: Verify the expected result.
            Assert.Equal(5, result);
        }
    }
}
