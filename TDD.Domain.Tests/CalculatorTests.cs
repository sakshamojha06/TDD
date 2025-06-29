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
    }
}
