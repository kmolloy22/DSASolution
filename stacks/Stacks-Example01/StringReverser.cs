using System.Text;

namespace Stacks_Example01
{
    public class StringReverser
    {
        public string Reverse(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentNullException();

            Stack<char> stack = new();

            foreach (var item in input.ToCharArray())
                stack.Push(item);

            var stringBuilder = new StringBuilder();
            while(stack.Count > 0)
                stringBuilder.Append(stack.Pop());

            
            return stringBuilder.ToString();
        }
    }
}
