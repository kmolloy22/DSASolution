using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructQueueWithArray_Example
{
    public class ConstructQueueWithArray
    {
        private readonly int _capacity;
        private int[] items;
        private int rear;
        private int count;

        public ConstructQueueWithArray(int capacity)
        {
            items = new int[capacity];
        }

        public void Enqueue(int item)
        {
            if(count == items.Length)
                throw new IndexOutOfRangeException();

            items[rear++] = item;
            count++;
        }

    }
}
