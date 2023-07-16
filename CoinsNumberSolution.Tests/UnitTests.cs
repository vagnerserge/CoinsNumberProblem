namespace CoinsNumberSolution.Tests
{
    public class UnitTests
    {

        [Fact]
        public void ShouldReturnMinimumCoins()
        {
            // Arrange
            int[] coins = { 1, 3, 5 };
            int amount = 22;
            int expectedMinimumCoins = 6;

            // Act
            int actualMinimumCoins = CoinsNumber.GetMinCoins(amount, coins);

            // Assert
            Assert.Equal(expectedMinimumCoins, actualMinimumCoins);
        }
        [Fact]
        public void ReturnZeroForZeroAmount()
        {
            // Arrange
            int[] coins = { 1, 3, 5 };
            int amount = 0;
            int expectedMinimumCoins = 0;

            // Act
            int actualMinimumCoins = CoinsNumber.GetMinCoins(amount, coins);

            // Assert
            Assert.Equal(expectedMinimumCoins, actualMinimumCoins);
        }

        [Fact]
        public void ReturnNegativeValueForNegativeAmount()
        {
            // Arrange
            int[] coins = { 1, 3, 5 };
            int amount = -10;
            int expectedMinimumCoins = -99;

            // Act
            int actualMinimumCoins = CoinsNumber.GetMinCoins(amount, coins);

            // Assert
            Assert.Equal(expectedMinimumCoins, actualMinimumCoins);
        }

        [Fact]
        public void ReturnNegativeValueForImpossibleAmount()
        {
            // Arrange
            int[] coins = { 2, 4, 6 };
            int amount = 11;
            int expectedMinimumCoins = -99;

            // Act
            int actualMinimumCoins = CoinsNumber.GetMinCoins(amount, coins);

            // Assert
            Assert.Equal(expectedMinimumCoins, actualMinimumCoins);
        }

        [Fact]
        public void ReturnNegativeValueForEmptyCoinsArray()
        {
            // Arrange
            int[] coins = {};
            int amount = 11;
            int expectedMinimumCoins = -99;

            // Act
            int actualMinimumCoins = CoinsNumber.GetMinCoins(amount, coins);

            // Assert
            Assert.Equal(expectedMinimumCoins, actualMinimumCoins);
        }

    }
}