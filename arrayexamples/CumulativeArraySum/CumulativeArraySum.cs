namespace CumulativeArraySumExample
{
    public class CumulativeArraySum
    {
        public double[] GetCumulativeArraySum(double[] array)
        {
            double sum = 0;
            return array.Select(num => sum += num).ToArray();
        }
    }
}
