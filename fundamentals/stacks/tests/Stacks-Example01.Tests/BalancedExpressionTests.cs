using BalancedExpression_Example;

namespace Stacks_Example01.Tests
{
    public class BalancedExpressionTests
    {
        private BalancedExpression _balancedExpression;

        public BalancedExpressionTests()
        {
            _balancedExpression = new BalancedExpression();
        }

        [Theory]
        [InlineData("(2 + 1)", true)]
        [InlineData("{2 + 1}", true)]
        [InlineData("(2 + 1", false)]
        [InlineData(")2 + 1(", false)]
        [InlineData("(2 + 1>", false)]
        public void GetBalancedExpression_ReturnBoolean(string input, bool expectedResult)
        {
            var result = _balancedExpression.IsBalanced(input);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void GetBalancedExpression_InvalidError_ThrowArgumentNullException(string? input)
        {
            Assert.Throws<ArgumentNullException>(() => _balancedExpression.IsBalanced(input));
        }

        [Theory]
        [InlineData('(', true)]
        [InlineData('{', true)]
        [InlineData('<', true)]
        [InlineData('[', true)]
        [InlineData('*', false)]
        public void GetIsLeftBracket_ReturnBoolean(char input, bool expectedResult)
        {
            var result = _balancedExpression.IsLeftBracket(input);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(')', true)]
        [InlineData('}', true)]
        [InlineData('>', true)]
        [InlineData(']', true)]
        [InlineData('*', false)]
        public void GetIsRightBracket_ReturnBoolean(char input, bool expectedResult)
        {
            var result = _balancedExpression.IsRightBracket(input);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData('(', ')', true)]
        [InlineData('{', '}', true)]
        [InlineData('<', '>', true)]
        [InlineData('[', ']', true)]
        [InlineData('(', '>',false)]
        public void GetIsBracketsMatch_ReturnBoolean(char left, char right, bool expectedResult)
        {
            var result = _balancedExpression.IsBracketsMatch(left, right);

            Assert.Equal(expectedResult, result);
        }
    }
}
