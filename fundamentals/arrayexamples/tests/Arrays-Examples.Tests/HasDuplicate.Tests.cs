using HasDuplicate_Example;

namespace Arrays_Examples.Tests;

public class HasDuplicateTests
{
    private HasDuplicate _hasDuplicate;

    public HasDuplicateTests()
    {
        _hasDuplicate = new HasDuplicate();
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 }, false)]
    [InlineData(new int[] { 1, 2, 3, 1 }, true)]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, false)]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1 }, true)]
    public void HasDuplicateNumbersBruteForce_ReturnBool(int[] nums, bool expectedResult)
    {
        var result = _hasDuplicate.HasDuplicateNumbersBruteForce(nums);
        Assert.Equal(expectedResult, result);

    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 }, false)]
    [InlineData(new int[] { 1, 2, 3, 1 }, true)]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, false)]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1 }, true)]
    [InlineData(new int[] { }, false)]
    [InlineData(new int[] { 42 }, false)]
    [InlineData(new int[] { 5, 5, 5 }, true)]
    [InlineData(new int[] { 9, 9, 1, 2, 3 }, true)]
    public void HasDuplicateNumbersHashSet_ReturnBool(int[] nums, bool expectedResult)
    {
        var result = _hasDuplicate.HasDuplicateNumbersHashSet(nums);
        Assert.Equal(expectedResult, result);
    }
}