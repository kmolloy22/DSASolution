namespace RemoveDuplicates_Example
{
    public class RemoveDuplicates
    {
        /// <summary>
        /// Removes duplicates using LINQ.
        /// Distinct() keeps a hash-based set of items already seen, so each check is about one step.
        /// Time: O(n) on average. Space: O(n).
        /// </summary>
        /// <param name="items">The array that may contain duplicates, e.g. [3,1,3,2,1].</param>
        /// <returns>A new array with each value once, e.g. [3,1,2].</returns>
        public object[] RemoveDupsWithLinq(object[] items)
        {
            // In practice this keeps first-appearance order, but the docs do not promise it.
            return items.Distinct().ToArray();
        }

        /// <summary>
        /// Removes duplicates with a manual loop, keeping the original order.
        /// Contains() scans the list from the start, so it runs up to n times for each of the n items.
        /// Time: O(n^2). Space: O(n) for the result list.
        /// </summary>
        /// <param name="items">The array that may contain duplicates, e.g. [3,1,3,2,1].</param>
        /// <returns>A new array with each value once, e.g. [3,1,2].</returns>
        public object[] RemoveDups(object[] items)
        {
            // A list grows as needed, so we do not need to know the final size up front.
            var uniqueItems = new List<object>();

            for (int i = 0; i < items.Length; i++)
            {
                // Only add an item the first time we see it. Later copies are skipped.
                if (!uniqueItems.Contains(items[i]))
                    uniqueItems.Add(items[i]);
            }

            return uniqueItems.ToArray();
        }
    }
}
