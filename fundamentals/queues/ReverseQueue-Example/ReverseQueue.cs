namespace ReverseQueue_Example
{
    public class ReverseQueue
    {

        public int[] Reverse(int[] array)
        {
            Queue<int> queue = new Queue<int>();
            foreach (var item in array)
                queue.Enqueue(item);

            Stack<int> stack = new();
            while(queue.Any())
                stack.Push(queue.Dequeue());

            while(stack.Any())
                queue.Enqueue(stack.Pop());

            return queue.ToArray();

        }
    }
}
