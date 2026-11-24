using BestTimeToBuySellStock_Example;

namespace Arrays_Examples.Tests;

public class BestTimeToBuySellStockTests
{
    private BuySellStock _buySellStock;

    public BestTimeToBuySellStockTests()
    {
        _buySellStock = new BuySellStock();
    }

    [Theory]
    [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4)]
    [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
    public void MaxProfitBruteForce_ReturnInt(int[] prices, int expectedResult)
    {
        var result = BuySellStock.MaxProfitBruteForce(prices);
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4)]
    [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
    public void MaxProfitOptimized_ReturnInt(int[] prices, int expectedResult)
    {
        var result = BuySellStock.MaxProfitOptimized(prices);
        Assert.Equal(expectedResult, result);
    }
}