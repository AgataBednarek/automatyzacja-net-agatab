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
        [Fact]
        public void Add_returns_sum_of_given_values()
        {
            // arrage
            var math = new Matematyka();

            // act
            var result = math.Add(10, 20);

            // assert
            Assert.Equal(30, result);
        }

        [Fact]
        public void Substract_returns_quotient_of_given_values()
        {
            // arrage
            var math = new Matematyka();

            // act
            var result = math.Substract(10, 20);

            // assert
            Assert.Equal(-10, result);
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
