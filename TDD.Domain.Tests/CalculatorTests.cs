using Xunit;

namespace TDD.Domain.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator = new Calculator();

        [Fact]
        public void Add_ReturnsSum()
        {
            var result = _calculator.Add(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Subtract_ReturnsDifference()
        {
            var result = _calculator.Subtract(5, 3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Multiply_ReturnsProduct()
        {
            var result = _calculator.Multiply(4, 3);
            Assert.Equal(12, result);
        }

        [Fact]
        public void Divide_ReturnsQuotient()
        {
            var result = _calculator.Divide(10, 2);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Divide_ThrowsNumeratorIsZeroException_WhenNumeratorIsZero()
        {
            Assert.Throws<NumeratorIsZeroException>(() => _calculator.Divide(0, 2));
        }

        [Fact]
        public void Divide_ThrowsDivideByZeroException_WhenDenominatorIsZero()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
        }
    }
}
