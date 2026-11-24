using TwoSum_Example;

namespace Arrays_Examples.Tests;

public class TwoSumTests
{
    private TwoSum _twoSum;

    public TwoSumTests()
    {
        _twoSum = new TwoSum();
    }

    [Theory]
    [InlineData(new int[] { 3, 4, 5, 6 }, 7, new int[] { 0, 1 })]
    [InlineData(new int[] { 4, 5, 6 }, 10, new int[] { 0, 2 })]
    public void FindTwoSumBruteForce_ReturnIntArray(int[] nums, int target, int[] expectedResult)
    {
        var result = _twoSum.FindTwoSumBruteForce(nums, target);

        Assert.Equivalent(expectedResult, result);
    }

    [Theory]
    [InlineData(new int[] { 3, 4, 5, 6 }, 7, new int[] { 0, 1 })]
    [InlineData(new int[] { 4, 5, 6 }, 10, new int[] { 0, 2 })]
    public void FindTwoSum_ReturnIntArray(int[] nums, int target, int[] expectedResult)
    {
        var result = _twoSum.FindTwoSum(nums, target);

        Assert.Equivalent(expectedResult, result);
    }
}