namespace FindMissingNumber_Example;

public class MissingNumber
{

    /// <summary>
    /// Finds the missing number by trying every candidate from 1 to the highest number
    /// and searching the array for each one.
    /// Assumes the numbers are 1 to n with no duplicates and exactly one missing. Order does not matter.
    /// Time: O(n^2), one search (inner loop) for each candidate (outer loop). Space: O(1).
    /// Known issue: an empty array should return 1, but this returns -1.
    /// </summary>
    /// <param name="nums">The array with one number missing, e.g. [1,2,4,5].</param>
    /// <returns>The missing number, e.g. 3.</returns>
    public int FindMissingNumberBruteForce(int[] nums)
    {
        // One number is missing, so the full list 1..highestNumber is one longer than the array.
        var highestNumber = nums.Length + 1;

        // Try each number that should be in the array.
        for(var candidate = 1; candidate <= nums.Length; candidate++)
        {
            // Search the array for the candidate.
            for(var index = 0; index < nums.Length; index++)
            {
                if (nums[index] == candidate)
                {
                    // Found it, so this candidate is not missing. Move on to the next candidate.
                    break;
                }

                // The match check above runs first, so reaching the last item here
                // means the whole array was searched without finding the candidate.
                if (index == nums.Length - 1)
                {
                    return candidate;
                }
            }
        }

        // Every number from 1 to nums.Length was found, so the highest number is the missing one.
        return highestNumber;
    }

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
