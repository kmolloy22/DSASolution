namespace HasDuplicate_Example;

public class HasDuplicate
{
    public bool HasDuplicateNumbersBruteForce(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    return true;
                }
            }
        }

        return false;
    }

    public bool HasDuplicateNumbersHashSet(int[] nums)
    {
        var seenNumbers = new HashSet<int>();
        foreach (var num in nums)
        {
            if (!seenNumbers.Add(num))
            {
                return true;
            }
        }

        return false;
    }
}