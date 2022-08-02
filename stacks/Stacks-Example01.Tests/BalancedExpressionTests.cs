using BalancedExpression_Example;

namespace Stacks_Example01.Tests
{
    public class BalancedExpressionTests
    {
        private BalancedExpression _balancedExpression;

        [SetUp]
        public void Setup()
        {
            _balancedExpression = new BalancedExpression();
        }

        [Test]
        [TestCase("(2 + 1)", true)]
        [TestCase("{2 + 1}", true)]
        [TestCase("(2 + 1", false)]
        [TestCase(")2 + 1(", false)]
        [TestCase("(2 + 1>", false)]
        public void GetBalancedExpression_ReturnBoolean(string input, bool expectedResult)
        {
            var result = _balancedExpression.IsBalanced(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void GetBalancedExpression_InvalidError_ThrowArgumentNullException(string input)
        {
            Assert.That(() => _balancedExpression.IsBalanced(input), Throws.ArgumentNullException);
        }

        [Test]
        [TestCase('(', true)]
        [TestCase('{', true)]
        [TestCase('<', true)]
        [TestCase('[', true)]
        [TestCase('*', false)]
        public void GetIsLeftBracket_ReturnBoolean(char input, bool expectedResult)
        {
            var result = _balancedExpression.IsLeftBracket(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(')', true)]
        [TestCase('}', true)]
        [TestCase('>', true)]
        [TestCase(']', true)]
        [TestCase('*', false)]
        public void GetIsRightBracket_ReturnBoolean(char input, bool expectedResult)
        {
            var result = _balancedExpression.IsRightBracket(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase("(", ")", true)]
        [TestCase('{', '}', true)]
        [TestCase('<', '>', true)]
        [TestCase('[', ']', true)]
        [TestCase('(', '>',false)]
        public void GetIsBracketsMatch_ReturnBoolean(char left, char right, bool expectedResult)
        {
            var result = _balancedExpression.IsBracketsMatch(left, right);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
