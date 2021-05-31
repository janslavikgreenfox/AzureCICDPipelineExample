using System;
using Xunit;
using BasketFiller;

namespace UnitTest
{
    public class UnitTests
    {
        [Fact]
        public void BasketFiller_Standard_Case()
        {
            // Arrange
            var test1 = new int[] { 4, 2, 7, 4, 2, 3 };
            var limit1 = 15;
            var expected = new int[] { 4, 2, 7 };

            // Act
            var result = Program.BasketFiller(test1, limit1);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void BasketFiller_Standard_Case_No2()
        {
            // Arrange
            var test1 = new int[] { 1, 1, 10, 5, 0, 1, 2, 6 };
            var limit1 = 18;
            var expected = new int[] { 1, 1, 10, 5, 0, 1 };

            // Act
            var result = Program.BasketFiller(test1, limit1);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
// this is the comment line to make a change to test the git pipeline
// Another comment line 
