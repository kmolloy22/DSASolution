using CheckPalindromeArray;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Examples.Tests;

[TestFixture]
public class CheckPalindromeArrayTests
{
    private CheckPalindrome _checkPalindrome;

    [SetUp]
    public void Setup()
    {
        _checkPalindrome = new CheckPalindrome();
    }

    [Test]
    [TestCase(new int[] { 1, 2, 3, 2, 1 }, true)]
    [TestCase(new int[] { 1, 2, 2, 1 }, true)]
    [TestCase(new int[] { 1, 2, 3 }, false)]
    [TestCase(new int[] { 7 }, true)]
    [TestCase(new int[] { }, true)]
    [TestCase(new int[] { 1, 2, 3, 4, 2, 1 }, false)]
    public void IsPalindrome_ReturnBool(int[] nums, bool expectedResult)
    {
        var result = _checkPalindrome.IsPalindrome(nums);
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
