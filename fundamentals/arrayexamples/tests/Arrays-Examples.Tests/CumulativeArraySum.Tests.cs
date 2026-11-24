using CumulativeArraySumExample;

namespace Arrays_Examples.Tests
{
    public class CumulativeArraySumTests
    {
        private CumulativeArraySum _cumulativeArraySum;

        public CumulativeArraySumTests()
        {
            _cumulativeArraySum = new CumulativeArraySum();
        }

        [Theory]
        [InlineData(new double[] { 1, 2, 3}, new double[] { 1, 3, 6})]
        [InlineData(new double[] { 1, -2, 3 }, new double[] { 1, -1, 2 })]
        [InlineData(new double[] { 3, 3, -2, 408, 3, 3 }, new double[] { 3, 6, 4, 412, 415, 418 })]
        public void GetCumulativeArraySum_ReturnDoubleArray(double[] array, double[] expectedResult)
        {
            var result =_cumulativeArraySum.GetCumulativeArraySum(array);
            
            Assert.Equivalent(expectedResult, result);
        }

        [Theory]
        [InlineData(new double[] {}, new double[] {})]
        [InlineData(new double[0] {}, new double[] {})]
        public void GetCumulativeArraySum_ReturnEmptyArray(double[] array, double[] expectedResult)
        {
            var result = _cumulativeArraySum.GetCumulativeArraySum(array);

            Assert.Equivalent(expectedResult, result);
        }
    }
}