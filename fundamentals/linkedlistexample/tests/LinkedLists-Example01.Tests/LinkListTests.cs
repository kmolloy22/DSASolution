namespace LinkedLists_Example01.Tests
{
    public class LinkListTests
    {
        private LinkedList _list;
        
        public LinkListTests()
        {
            _list = new LinkedList();
        }

        [Theory]
        [InlineData(0)]
        public void GetSize_InitialList_ReturnZero(int expectedResult)
        {
            var result = _list.Size();

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(1)]
        public void GetSize_AddFirstOneElement_ReturnOne(int expectedResult)
        {
            _list.AddFirst(10);

            var result = _list.Size();

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(1)]
        public void GetSize_AddLastOneElement_ReturnOne(int expectedResult)
        {
            _list.AddLast(10);

            var result = _list.Size();

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(10, 20, 10)]
        [InlineData(50, 20, 50)]
        public void GetFirst_MultipleElements_ReturnFirstElement(int first, int last, int expectedResult)
        {
            _list.AddLast(first);
            _list.AddLast(last);

            var result = _list.GetFirst();

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(10, 20, 20)]
        [InlineData(50, 30, 30)]
        public void GetLast_MultipleElements_ReturnLastElement(int first, int last, int expectedResult)
        {
            _list.AddLast(first);
            _list.AddLast(last);

            var result = _list.GetLast();

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(10, 20, 10, true)]
        [InlineData(10, 20, 50, false)]
        public void GetContains_MultipleElements_ReturnTrue(int first, int last,
            int containedValue, bool expectedResult)
        {
            _list.AddLast(first);
            _list.AddLast(last);

            var result = _list.Contains(containedValue);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(10, 20, 30, 10, 0)]
        [InlineData(10, 20, 30, 20, 1)]
        [InlineData(10, 20, 50, 50, 2)]
        public void GetIndexOf_MultipleElements_ReturnIndexofElement(int first, int middle,
            int last, int indexVal, int expectedResult)
        {
            _list.AddFirst(first);
            _list.AddLast(middle);
            _list.AddLast(last);

            var result = _list.IndexOf(indexVal);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(10, 20, 30, 2, 20)]
        [InlineData(10, 50, 30, 2, 50)]
        public void RemoveFirst_ReturnNewFirst_ReturnNewSize(int first, int middle,
            int last, int expectedNewSize, int expectedNewFirst)
        {
            _list.AddFirst(first);
            _list.AddLast(middle);
            _list.AddLast(last);

            _list.RemoveFirst();

            var sizeResult = _list.Size();
            var firstResult = _list.GetFirst();

            Assert.Equal(expectedNewSize, sizeResult);
            Assert.Equal(expectedNewFirst, firstResult);
        }

        [Theory]
        [InlineData(10, 20, 30, 2, 20)]
        [InlineData(10, 50, 30, 2, 50)]
        public void RemoveLast_ReturnNewLast_ReturnNewSize(int first, int middle,
            int last, int expectedNewSize, int expectedNewLast)
        {
            _list.AddFirst(first);
            _list.AddLast(middle);
            _list.AddLast(last);

            _list.RemoveLast();

            var sizeResult = _list.Size();
            var lastResult = _list.GetLast();

            Assert.Equal(expectedNewSize, sizeResult);
            Assert.Equal(expectedNewLast, lastResult);
        }

        [Theory]
        [InlineData(10, 20, 30, 30, 10)]
        [InlineData(20, 50, 30, 30, 20)]
        public void ReverseList_MultipleElements_ReturnNewFirst_ReturnNewLast(int first, int middle,
            int last, int expectedNewFirst, int expectedNewLast)
        {
            _list.AddFirst(first);
            _list.AddLast(middle);
            _list.AddLast(last);

            _list.Reverse();

            var firstResult = _list.GetFirst();
            var lastResult = _list.GetLast();

            Assert.Equal(expectedNewFirst, firstResult);
            Assert.Equal(expectedNewLast, lastResult);
        }

        [Theory]
        [InlineData(10, 20, 30, 40, 2, 30)]
        [InlineData(10, 20, 30, 40, 1, 40)]
        [InlineData(10, 20, 30, 40, 4, 10)]
        [InlineData(10, 20, 30, 40, 3, 20)]
        public void GetKthFromTheEnd_MultipleElements_ReturnNodeValue(int first, int second,
            int third, int last, int k, int expectedResult)
        {
            _list.AddFirst(first);
            _list.AddLast(second);
            _list.AddLast(third);
            _list.AddLast(last);

            var result = _list.GetKthFromTheEnd(k);

            Assert.Equal(expectedResult, result);
        }

    }
}