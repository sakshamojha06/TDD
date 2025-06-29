namespace TDD.Domain
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            if (a == 0)
                throw new NumeratorIsZeroException("Numberator must me greater than 0");

            if (b == 0)
                throw new DivideByZeroException("Cannot divide by 0");

            return a / b;
        }
    }

    public class NumeratorIsZeroException: Exception
    {
        public NumeratorIsZeroException(string message): base(message) { }
    }
}