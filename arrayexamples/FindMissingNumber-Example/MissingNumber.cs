namespace FindMissingNumber_Example;

public class MissingNumber
{
    /// <summary>
    /// Finds the one missing number in an array that should hold 1 to n.
    /// Assumes no duplicates and exactly one number missing. Order does not matter.
    /// Idea: (sum of 1 to n) - (sum of the array) = the missing number.
    /// Time: O(n) for the loop. Space: O(1).
    /// </summary>
    /// <param name="nums">The array with one number missing, e.g. [1,2,4,5].</param>
    /// <returns>The missing number, e.g. 3.</returns>
    public int FindMissingNumber(int[] nums)
    {
        // One number is missing, so the full list is one longer than the array.
        // Using length + 1 (not the largest value) also works when the missing number is the largest.
        // long avoids int overflow: n * (n + 1) passes int.MaxValue at about n = 46,341.
        long n = nums.Length + 1;

        // x = sum of 1 to n, using the formula n * (n + 1) / 2 instead of a loop.
        // The division is exact because n * (n + 1) is always even.
        long x = n * (n + 1) / 2;

        // y = sum of the numbers actually in the array.
        long y = 0;
        for(var i = 0; i < nums.Length; i++)
        {
            y += nums[i];
        }

        // The two sums differ only by the missing number, so the difference is the answer.
        // The cast is safe: the result is always between 1 and n.
        return (int)(x - y);
    }
}
