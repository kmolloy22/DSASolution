using TwoSum_Example;

namespace Arrays_Examples.Tests;

[TestFixture]
public class TwoSumTests
{
    private TwoSum _twoSum;

    [SetUp]
    public void Setup()
    {
        _twoSum = new TwoSum();
    }

    [Test]
    [TestCase(new int[] { 3, 4, 5, 6 }, 7, new int[] { 0, 1 })]
    [TestCase(new int[] { 4, 5, 6 }, 10, new int[] { 0, 2 })]
    public void FindTwoSumBruteForce_ReturnIntArray(int[] nums, int target, int[] expectedResult)
    {
        var result = _twoSum.FindTwoSumBruteForce(nums, target);

        Assert.That(result, Is.EquivalentTo(expectedResult));
    }

    [Test]
    [TestCase(new int[] { 3, 4, 5, 6 }, 7, new int[] { 0, 1 })]
    [TestCase(new int[] { 4, 5, 6 }, 10, new int[] { 0, 2 })]
    public void FindTwoSum_ReturnIntArray(int[] nums, int target, int[] expectedResult)
    {
        var result = _twoSum.FindTwoSum(nums, target);

        Assert.That(result, Is.EquivalentTo(expectedResult));
    }
}