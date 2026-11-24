using HasDuplicate_Example;

namespace Arrays_Examples.Tests;

public class HasDuplicateTests
{
    private HasDuplicate _hasDuplicate;

    public HasDuplicateTests()
    {
        _hasDuplicate = new HasDuplicate();
    }

    [Test]
    [TestCase(new int[] { 1, 2, 3, 4 }, false)]
    [TestCase(new int[] { 1, 2, 3, 1 }, true)]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, false)]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1 }, true)]
    public void HasDuplicateNumbersBruteForce_ReturnBool(int[] nums, bool expectedResult)
    {
        var result = _hasDuplicate.HasDuplicateNumbersBruteForce(nums);
        Assert.That(result, Is.EqualTo(expectedResult));

    }

    [Test]
    [TestCase(new int[] { 1, 2, 3, 4 }, false)]
    [TestCase(new int[] { 1, 2, 3, 1 }, true)]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, false)]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1 }, true)]
    [TestCase(new int[] { }, false)]
    [TestCase(new int[] { 42 }, false)]
    [TestCase(new int[] { 5, 5, 5 }, true)]
    [TestCase(new int[] { 9, 9, 1, 2, 3 }, true)]
    public void HasDuplicateNumbersHashSet_ReturnBool(int[] nums, bool expectedResult)
    {
        var result = _hasDuplicate.HasDuplicateNumbersHashSet(nums);
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}