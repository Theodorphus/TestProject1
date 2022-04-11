

using Xunit;
using TestProject1;

namespace TestProject1
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(4, 3, 7)]

        [InlineData(9, -9, 0)]
        public void ShouldAddTwoNumbers(double x, double y, double expected)
        {
            //Act
            double actual = Calculator.Add(x, y);
            //Assert
            Assert.Equal(expected, actual);
        }



        [Fact]
        public void AddArrays()
        {


            double[] x = { 1, 2, 3, 4, 5 };
            double[] y = { 1, 2, 3, 4, 5 };

            var calculator = new Calculator();
           var actual = Calculator.Add(x[1], y[2]);

            Assert.Equal(5, actual);


        }

        [Fact]
        public void SubtractArrays()
        {


            double[] x = { 1, 2, 3, 4, 5 };
            double[] y = { 1, 2, 3, 4, 5 };

            var calculator = new Calculator();
            var actual = Calculator.Subtract(x[1], y[2]);

            Assert.Equal(-1, actual);


        }
        [Theory]
        [InlineData(4, 3, 1)]
            
        [InlineData(-9, -9, 0)]
        public void ShouldSubtractTwoNumbers(double x, double y, double expected)
        {
            double actual = Calculator.Subtract(x, y);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(4, 3, 12)]
     
        [InlineData(0, 3, 0)]
        public void ShouldMultiplyTwoNumbers(double x, double y, double expected)
        {
            double actual = Calculator.Multiply(x, y);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 4, 1)]
        [InlineData(5, 0, 0)]
        [InlineData(0, 3, 0)]
        public void ShouldDivideTwoNumbers(double x, double y, double expected)
        {
            double actual = Calculator.Divide(x, y);
            Assert.Equal(expected, actual);
        }
    }
}
