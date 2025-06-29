namespace TDD.Domain.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ReturnsSumOfTwoNumbers()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Add(5, 10);

            //Assert
            Assert.Equal(15, result);
        }

        [Fact]
        public void Subtract_ReturnsSubtractionOfTwoNumbers()
        {
            //Arrange
            var calculator = GetCalculator();

            //Act
            var result = calculator.Subtract(10, 5);

            //Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Multiply_ReturnsMultiplicationOfTwoNumbers()
        {
            //Arrange
            var calculator = GetCalculator();

            //Act
            var result = calculator.Multiply(10, 5);

            //Assert
            Assert.Equal(50, result);
        }

        [Fact]
        public void Divide_ReturnsDivisionOfTwoNumbers()
        {
            //Arrange
            var calculator = GetCalculator();

            //Act
            var result = calculator.Divide(10, 2);

            //Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Divide_Retuns0IfNumberatorIs0()
        {
            //Arrange
            var calculator = GetCalculator();

            //Act
            var result = calculator.Divide(0, 500);

            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Divide_Throws_DivideByZeroException_If_Denominator_Is_0()
        {
            //Arrange
            var calculator = GetCalculator();

            //Act
            var exception = Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));

            //Assert
            Assert.Equal("Cannot divide by 0", exception.Message);
        }

        private Calculator GetCalculator()
        {
            return new Calculator();
        }
    }
}
