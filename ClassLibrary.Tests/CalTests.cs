using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator_ClassLibrary;
using Xunit;

namespace ClassLibrary.Tests
{
    public class CalTests
    {  
        // ADD
        [Theory]
        [InlineData(5,5,10)]
        [InlineData(2.5,2.6,5.1)]
        [InlineData(double.MaxValue,5, double.MaxValue)]
        public void Add_SimpleValueShouldCalculate(double x,double y, double expected)
        {
            // Arrange


            // Act

            double actual = Cal.Add(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }
        
        // Subtract
        [Theory]
        [InlineData(8, 4, 4)]
        public void Subtract_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            // Arrange


            // Act

            double actual = Cal.subtract(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }
     
        // Multiply
        [Theory]
        [InlineData(8, 4, 32)]
        public void Multiply_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            // Arrange


            // Act

            double actual = Cal.Multiply(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }
      
        // Devide
        [Theory]
        [InlineData(8,4,2)]
        public void Devide_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            // Arrange


            // Act

            double actual = Cal.Divide(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DevidedByZero()
        {
            // Arrange
            double expected = 0;

            // Act

            double actual = Cal.Divide(15, 0);

            // Assert
            Assert.Equal(expected, actual);
        }

    }
}
