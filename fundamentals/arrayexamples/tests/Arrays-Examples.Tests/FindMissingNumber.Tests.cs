using FindMissingNumber_Example;

namespace Arrays_Examples.Tests;

public class FindMissingNumberTests
{
    private MissingNumber _missingNumber;

    public FindMissingNumberTests()
    {
        _missingNumber = new MissingNumber();
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 4, 5 }, 3)]
    [InlineData(new int[] { 2, 3, 1, 5 }, 4)]
    [InlineData(new int[] { 1, 2, 3, 4 }, 5)]
    [InlineData(new int[] { 2, 3, 4, 5 }, 1)]
    [InlineData(new int[] { 1 }, 2)]
    [InlineData(new int[] { 2 }, 1)]
    public void FindMissingNumber_BruteForce_ReturnInt(int[] nums, int expectedResult)
    {
        var result = _missingNumber.FindMissingNumberBruteForce(nums);
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 4, 5 }, 3)]
    [InlineData(new int[] { 2, 3, 1, 5 }, 4)]
    [InlineData(new int[] { 1, 2, 3, 4}, 5)]
    [InlineData(new int[] { 2, 3, 4, 5 }, 1)]
    [InlineData(new int[] { 1 }, 2)]
    [InlineData(new int[] { 2 }, 1)]
    public void FindMissingNumber_ReturnInt(int[] nums, int expectedResult)
    {
        var result = _missingNumber.FindMissingNumber(nums);
        Assert.Equal(expectedResult, result);
    }
}