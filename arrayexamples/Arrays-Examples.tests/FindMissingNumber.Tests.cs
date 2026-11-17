using FindMissingNumber_Example;

namespace Arrays_Examples.Tests;

[TestFixture]
public class FindMissingNumberTests
{
    private MissingNumber _missingNumber;

    [SetUp]
    public void Setup()
    {
        _missingNumber = new MissingNumber();
    }

    [Test]
    [TestCase(new int[] { 1, 2, 4, 5 }, 3)]
    [TestCase(new int[] { 2, 3, 1, 5 }, 4)]
    [TestCase(new int[] { 1, 2, 3, 4}, 5)]
    [TestCase(new int[] { 2, 3, 4, 5 }, 1)]
    [TestCase(new int[] { 1 }, 2)]
    [TestCase(new int[] { 2 }, 1)]
    public void FindMissingNumber_ReturnInt(int[] nums, int expectedResult)
    {
        var result = _missingNumber.FindMissingNumber(nums);
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}