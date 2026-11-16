namespace CheckPalindromeArray;

public class CheckPalindrome
{
    public bool IsPalindrome(int[] nums)
    {
        var left = 0;
        var right = nums.Length - 1;

        while(left < right)
        {
            if (nums[left] != nums[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}
