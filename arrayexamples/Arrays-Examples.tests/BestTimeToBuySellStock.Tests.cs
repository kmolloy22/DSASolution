using BestTimeToBuySellStock_Example;

namespace Arrays_Examples.Tests;

[TestFixture]
public class BestTimeToBuySellStockTests
{
    private BuySellStock _buySellStock;

    [SetUp]
    public void Setup()
    {
        _buySellStock = new BuySellStock();
    }

    [Test]
    [TestCase(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4)]
    [TestCase(new int[] { 7, 6, 4, 3, 1 }, 0)]
    public void MaxProfitBruteForce_ReturnInt(int[] prices, int expectedResult)
    {
        var result = BuySellStock.MaxProfitBruteForce(prices);
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4)]
    [TestCase(new int[] { 7, 6, 4, 3, 1 }, 0)]
    public void MaxProfitOptimized_ReturnInt(int[] prices, int expectedResult)
    {
        var result = BuySellStock.MaxProfitOptimized(prices);
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}