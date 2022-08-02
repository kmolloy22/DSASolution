namespace BalancedExpression_Example
{
    public class BalancedExpression
    {
        private List<char> leftBrackets = new() { '(', '<', '[', '{' };
        private List<char> rightBrackets = new() { ')', '>', ']', '}' };

        public bool IsBalanced(string input)
        {
            if(string.IsNullOrWhiteSpace(input))
                throw new ArgumentNullException();

            Stack<char> stack = new();

            foreach (char item in input.ToCharArray())
            {
                if(IsLeftBracket(item))
                    stack.Push(item);

                if (IsRightBracket(item))
                {
                    if(stack.Count == 0)
                        return false;

                    var top = stack.Pop();
                    if (!IsBracketsMatch(top, item)) return false;
                }

            }

            return stack.Count == 0;
        }

        public bool IsLeftBracket(char item)
        {
            return leftBrackets.Contains(item);
        }

        public bool IsRightBracket(char item)
        {
            return rightBrackets.Contains(item);

        }
        public bool IsBracketsMatch(char left, char right)
        {
            return leftBrackets.IndexOf(left) == rightBrackets.IndexOf(right);
        }

    }
}
