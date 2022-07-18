namespace LinkedLists_Example01
{
    public class LinkedList
    {
        private class Node
        {
            internal int value;
            internal Node next;

            public Node(int value)
            {
                this.value = value;
            }
        }

        private Node first;
        private Node last;
        private int size;

        // addFirst
        public void AddFirst(int item)
        {
            var node = new Node(item);

            if (IsEmpty())
                first = last = node;
            else
            {
                node.next = first;
                first = node;
            }
            size++;
        }

        // addLast
        public void AddLast(int item)
        {
            var node = new Node(item);

            if (IsEmpty())
                first = last = node;
            else
            {
                last.next = node;
                last = node;
            }
            size++;
        }       
        
        // removeFirst
        public void RemoveFirst()
        {
            if (IsEmpty())
                throw new InvalidOperationException();

            if (first == last)
                first = last = null;
            else
            {
                var second = first.next;
                first.next = null;
                first = second;
            }
            size--;
        }

        // removeLast
        public void RemoveLast()
        {
            if (IsEmpty())
                throw new InvalidOperationException();

            if (first == last)
                first = last = null;
            else
            {
                var previous = GetPrevious(last);
                last = previous;
                last.next = null;
            }
            size--;
        }

        // contains
        public bool Contains(int item) => IndexOf(item) != -1;

        // size -> O(1)
        public int Size() => size;

        // convert to array
        public int[] ToArray()
        {
            int[] array = new int[size];
            var current = first;
            var index = 0;
            while(current != null)
            {
                array[index++] = current.value;
                current = current.next;
            }

            return array;
        }

        public void Reverse()
        {
            if (IsEmpty()) return;

            var previous = first;
            var current = first.next;

            while(current != null)
            {
                var next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }

            last = first;
            last.next = null;
            first = previous;
        }

        // indexOf
        public int IndexOf(int item)
        {
            int index = 0;
            var current = first;
            while(current != null)
            {
                if (current.value == item) return index;
                current = current.next;
                index++;
            }

            return -1;
        }

        public int GetKthFromTheEnd(int k)
        {
            if (IsEmpty())
                throw new ArgumentOutOfRangeException();

            var a = first;
            var b = first;

            for (int i = 0; i < k - 1; i++)
            {
                b = b.next;
                if (b == null)
                    throw new ArgumentOutOfRangeException();
            }
                

            while(b != last)
            {
                a = a.next;
                b = b.next;
            }

            return a.value;
        }

        #region private methods
        private bool IsEmpty() => first == null;

        private Node GetPrevious(Node node)
        {
            var current = first;
            while(current != null)
            {
                if(current.next == node) return current;
                current = current.next;
            }

            return null;
        }
        #endregion

    }
}
