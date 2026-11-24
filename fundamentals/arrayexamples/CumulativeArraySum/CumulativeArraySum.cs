namespace CumulativeArraySumExample
{
    public class CumulativeArraySum
    {
        /// <summary>
        /// Returns the running total at each position: [1,2,3] -> [1,3,6].
        /// Each output item is the sum of all input items up to and including that position.
        /// Time: O(n), one pass. Space: O(n) for the new array.
        /// </summary>
        /// <param name="array">The numbers to add up, e.g. [1,-2,3].</param>
        /// <returns>A new array of running totals, e.g. [1,-1,2]. An empty array gives an empty array.</returns>
        public double[] GetCumulativeArraySum(double[] array)
        {
            // The running total, carried from one item to the next.
            double sum = 0;

            // For each number, add it to the running total, then use the new total as the output item.
            // Select runs in order and the total is updated as it goes, so ToArray() must run only once.
            return array.Select(num => sum += num).ToArray();
        }
    }
}
