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
        public void GetReversedString_UsingStack_ReturnString()
        {
            Assert.Pass();
        }
    }
}