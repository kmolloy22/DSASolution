using CumulativeArraySumExample;

namespace Arrays_Examples.Tests
{
    [TestFixture]
    public class CumulativeArraySumTests
    {
        private CumulativeArraySum _cumulativeArraySum;

        [SetUp]
        public void Setup()
        {
            _cumulativeArraySum = new CumulativeArraySum();
        }

        [Test]
        [TestCase(new double[] { 1, 2, 3}, new double[] { 1, 3, 6})]
        [TestCase(new double[] { 1, -2, 3 }, new double[] { 1, -1, 2 })]
        [TestCase(new double[] { 3, 3, -2, 408, 3, 3 }, new double[] { 3, 6, 4, 412, 415, 418 })]
        public void GetCumulativeArraySum_ReturnDoubleArray(double[] array, double[] expectedResult)
        {
            var result =_cumulativeArraySum.GetCumulativeArraySum(array);
            
            Assert.That(result, Is.EquivalentTo(expectedResult));
        }

        [Test]
        [TestCase(new double[] {}, new double[] {})]
        [TestCase(new double[0] {}, new double[] {})]
        public void GetCumulativeArraySum_ReturnEmptyArray(double[] array, double[] expectedResult)
        {
            var result = _cumulativeArraySum.GetCumulativeArraySum(array);

            Assert.That(result, Is.EquivalentTo(expectedResult));
        }
    }
}