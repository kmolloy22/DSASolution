namespace HasDuplicate_Example;

public class HasDuplicate
{
    /// <summary>
    /// Checks for a duplicate by comparing every number with every number after it.
    /// Time: O(n^2), because of the nested loops. Space: O(1), no extra storage.
    /// </summary>
    /// <param name="nums">The numbers to check, e.g. [1,2,3,1].</param>
    /// <returns>true if any value appears more than once, otherwise false.</returns>
    public bool HasDuplicateNumbersBruteForce(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            // Start at i + 1 so each pair is checked once and a number is never compared with itself.
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    // Found a duplicate, so there is no need to keep checking.
                    return true;
                }
            }
        }

        // Every pair was checked and none matched.
        return false;
    }

    /// <summary>
    /// Checks for a duplicate using a HashSet, which stores each value only once.
    /// Time: O(n) on average. Space: O(n) for the set.
    /// </summary>
    /// <param name="nums">The numbers to check, e.g. [1,2,3,1].</param>
    /// <returns>true if any value appears more than once, otherwise false.</returns>
    public bool HasDuplicateNumbersHashSet(int[] nums)
    {
        // Remembers every number we have already seen.
        var seenNumbers = new HashSet<int>();
        foreach (var num in nums)
        {
            // Add returns false when the value is already in the set, which means a duplicate.
            if (!seenNumbers.Add(num))
            {
                return true;
            }
        }

        // Every number was new, so there are no duplicates (this also covers an empty array).
        return false;
    }
}
