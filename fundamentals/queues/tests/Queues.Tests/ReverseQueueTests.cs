using ReverseQueue_Example;

namespace Queues.Tests
{
    public class ReverseQueueTests
    {
        private ReverseQueue _reverseQueus;

        public ReverseQueueTests()
        {
            _reverseQueus = new ReverseQueue();
        }

        [Theory]
        [InlineData(new int[] { 10, 20, 30 }, new int[] { 30, 20, 10 })]
        [InlineData(new int[] { 100, 200, 300 }, new int[] { 300, 200, 100 })]
        public void ReverseQueue_SendArray_ReturnReversedArray(int[] array, int[] expectedResult)
        {

            var result = _reverseQueus.Reverse(array);

            Assert.Equivalent(expectedResult, result);
        }
    }
}