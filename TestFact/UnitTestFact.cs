using FactorielFunction;
using Xunit;

namespace TestFact
{
    public class UnitTestFact
    {
        [Fact]
        
        public void FactRecursive_ReturnCorrectResult()
        {
            // Arrange
            int input = 4;
            long expected = 24;

            // Act
            long result = Fact.FactRecursive(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void FactIterative_ReturnCorrectResult()
        {
            // Arrange
            int input = 3;
            long expected = 6;

            // Act
            long result = Fact.FactIterative(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}