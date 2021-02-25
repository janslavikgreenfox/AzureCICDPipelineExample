using System;
using Xunit;
using BasketFiller;

namespace UnitTest
{
    public class UnitTest1
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
    }
}
