namespace TwoSum_Example;

public class TwoSum
{
    // Brute-force approach: O(n^2) time complexity
    // This method iterates through each pair of numbers
    // in the array and checks if their sum equals the target.
    public int[] FindTwoSumBruteForce(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }

        throw new InvalidOperationException("No two sum solution found.");
    }

    // Optimized approach: O(n) time, O(n) space
    public int[] FindTwoSum(int[] nums, int target)
    {
        var seenNumbers = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (seenNumbers.TryGetValue(complement, out int complementIndex))
            {
                return new int[] { complementIndex, i };
            }

            seenNumbers[nums[i]] = i;
        }

        throw new InvalidOperationException("No two sum solution found.");
    }
}