namespace Stacks_Example01.Tests
{
    public class StringReverserTests
    {
        private StringReverser _reverser;
        [SetUp]
        public void Setup()
        {
            _reverser = new StringReverser();
        }

        [Test]
        [TestCase("abcde", "edcba")]
        [TestCase("xyz", "zyx")]
        public void GetReversedString_UsingStack_ReturnString(string input, string expectedResult)
        {
            var result = _reverser.Reverse(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void GetReversedString_InvalidError_ThrowArgumentNullException(string input)
        {
            Assert.That(() => _reverser.Reverse(input), Throws.ArgumentNullException);
        }
    }
}