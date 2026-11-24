using ReverseQueue_Example;

namespace Queues.Tests
{
    public class ReverseQueueTests
    {
        private ReverseQueue _reverseQueus;

        [SetUp]
        public void Setup()
        {
            _reverseQueus = new ReverseQueue();
        }

        [Test]
        [TestCase(new int[] { 10, 20, 30 }, new int[] { 30, 20, 10 })]
        [TestCase(new int[] { 100, 200, 300 }, new int[] { 300, 200, 100 })]
        public void ReverseQueue_SendArray_ReturnReversedArray(int[] array, int[] expectedResult)
        {

            var result = _reverseQueus.Reverse(array);

            Assert.That(result, Is.EquivalentTo(expectedResult));
        }
    }
}