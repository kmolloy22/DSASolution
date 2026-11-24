namespace Stacks_Example01.Tests
{
    public class StringReverserTests
    {
        private StringReverser _reverser;
        public StringReverserTests()
        {
            _reverser = new StringReverser();
        }

        [Theory]
        [InlineData("abcde", "edcba")]
        [InlineData("xyz", "zyx")]
        public void GetReversedString_UsingStack_ReturnString(string input, string expectedResult)
        {
            var result = _reverser.Reverse(input);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void GetReversedString_InvalidError_ThrowArgumentNullException(string? input)
        {
            Assert.Throws<ArgumentNullException>(() => _reverser.Reverse(input));
        }
    }
}