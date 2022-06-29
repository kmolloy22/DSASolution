namespace Arrays_Example01
{
    public class Array
    {
        private int[] items;
        private int count;

        public Array(int length)
        {
            items = new int[length];
        }

        public void Insert(int number)
        {
            // construct dynamic array
            ResizeIfRequired();

            items[count++] = number;
        }

        private void ResizeIfRequired()
        {
            if (items.Length == count)
            {
                int[] newItems = new int[count * 2];

                for (int i = 0; i < count; i++)
                {
                    newItems[i] = items[i];
                }
                items = newItems;
            }
        }

        public void RemoveAt(int index)
        {
            // validate the index
            if(index < 0 || index >= count)
                throw new ArgumentOutOfRangeException("index");

            for (int i = index; i < count; i++)
            {
                items[i] = items[i + 1];
            }

            count--;

        }

        public int IndexOf(int number)
        {
            // O(1) - best case scenario (first index)
            // O(n) - worst case scenario (needs to iterate through entire array)
            for (int i = 0; i < count; i++)
            {
                if (items[i] == number)
                    return i;
            }

            return -1;
        }

        public int Max()
        {
            int max = 0;
            for (int i = 0; i < count; i++)
                if(items[i] > max)
                    max = items[i];
            
            return max;
        }

        public Array Intersect(Array other)
        {
            var intersection = new Array(count);

            foreach (var item in items)
                if (other.IndexOf(item) >= 0)
                    intersection.Insert(item);
            
            return intersection;
        }

        public void Reverse()
        {
            int[] newitems = new int[count];

            for (int i = 0; i < count; i++)
                newitems[i] = items[count - i - 1];

            items = newitems;
        }

        public void InsertAt(int item, int index)
        {
            if (index < 0 || index > count)
                throw new ArgumentOutOfRangeException();

            ResizeIfRequired();

            for (int i = count - 1; i >= index; i--)
                items[i + 1] = items[i];

            items[index] = item;
            count++;

        }

        public void print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(items[i]);
            }
            Console.WriteLine();
        }
    }
}
