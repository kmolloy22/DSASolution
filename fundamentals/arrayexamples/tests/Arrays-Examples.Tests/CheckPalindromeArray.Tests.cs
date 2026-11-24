using CheckPalindromeArray;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Examples.Tests;

public class CheckPalindromeArrayTests
{
    private CheckPalindrome _checkPalindrome;

    public CheckPalindromeArrayTests()
    {
        _checkPalindrome = new CheckPalindrome();
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 2, 1 }, true)]
    [InlineData(new int[] { 1, 2, 2, 1 }, true)]
    [InlineData(new int[] { 1, 2, 3 }, false)]
    [InlineData(new int[] { 7 }, true)]
    [InlineData(new int[] { }, true)]
    [InlineData(new int[] { 1, 2, 3, 4, 2, 1 }, false)]
    public void IsPalindrome_ReturnBool(int[] nums, bool expectedResult)
    {
        var result = _checkPalindrome.IsPalindrome(nums);
        Assert.Equal(expectedResult, result);
    }
}
