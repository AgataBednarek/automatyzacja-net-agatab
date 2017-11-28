using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Cwiczenie1
{
    public class MathematicsTest
    {
        [Theory]
        [InlineData(10,20,30)]
        [InlineData(10, 100, 110)]
        [InlineData(5, 20, 25)]
        [InlineData(5, 5, 10)]
        [InlineData(8, 4, 12)]
        [InlineData(10, 2, 12)]
        public void TheoryExample(double x, double y, double expected)
        {
            // arrage
            var math = new Matematyka();

            // act
            var result = math.Add(x, y);

            // assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Add2_returns_sum_of_given_values()
        {
            // arrage
            var math = new Matematyka();

            // act
            var result = math.Add(10, 100);

            // assert
            Assert.Equal(110, result);
        }


        [Fact]
        public void Substract_returns_quotient_of_given_values()
        {
            // arrage
            var math = new Matematyka();

            // act
            var result = math.Substract(5, 20);

            // assert
            Assert.Equal(-15, result);
        }

        [Fact]
        public void Multiply_returns_multiplycasion_of_given_values()
        {
            // arrage
            var math = new Matematyka();

            // act
            var result = math.Multiply(5, 5);

            // assert
            Assert.Equal(25, result);
        }

        [Fact]
        public void Division_returns_divider_of_given_values()
        {
            // arrage
            var math = new Matematyka();

            // act
            var result = math.Division(8, 4);
            
            // assert
            Assert.Equal(2, result);
        }
        [Fact]
        public void Division_returns_divider2_of_given_values()
        {
            // arrage
            var math = new Matematyka();

            // act
            var result = math.Division(10, 2);

            // assert
            Assert.Equal(5, result);
        }
    }
}
