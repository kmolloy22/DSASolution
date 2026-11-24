namespace LinkedLists_Example01.Tests
{
    [TestFixture]
    public class LinkListTests
    {
        private LinkedList _list;
        
        [SetUp]
        public void Setup()
        {
            _list = new LinkedList();
        }

        [Test]
        [TestCase(0)]
        public void GetSize_InitialList_ReturnZero(int expectedResult)
        {
            var result = _list.Size();

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(1)]
        public void GetSize_AddFirstOneElement_ReturnOne(int expectedResult)
        {
            _list.AddFirst(10);

            var result = _list.Size();

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(1)]
        public void GetSize_AddLastOneElement_ReturnOne(int expectedResult)
        {
            _list.AddLast(10);

            var result = _list.Size();

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(10, 20, 10)]
        [TestCase(50, 20, 50)]
        public void GetFirst_MultipleElements_ReturnFirstElement(int first, int last, int expectedResult)
        {
            _list.AddLast(first);
            _list.AddLast(last);

            var result = _list.GetFirst();

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(10, 20, 20)]
        [TestCase(50, 30, 30)]
        public void GetLast_MultipleElements_ReturnLastElement(int first, int last, int expectedResult)
        {
            _list.AddLast(first);
            _list.AddLast(last);

            var result = _list.GetLast();

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(10, 20, 10, true)]
        [TestCase(10, 20, 50, false)]
        public void GetContains_MultipleElements_ReturnTrue(int first, int last,
            int containedValue, bool expectedResult)
        {
            _list.AddLast(first);
            _list.AddLast(last);

            var result = _list.Contains(containedValue);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(10, 20, 30, 10, 0)]
        [TestCase(10, 20, 30, 20, 1)]
        [TestCase(10, 20, 50, 50, 2)]
        public void GetIndexOf_MultipleElements_ReturnIndexofElement(int first, int middle,
            int last, int indexVal, int expectedResult)
        {
            _list.AddFirst(first);
            _list.AddLast(middle);
            _list.AddLast(last);

            var result = _list.IndexOf(indexVal);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(10, 20, 30, 2, 20)]
        [TestCase(10, 50, 30, 2, 50)]
        public void RemoveFirst_ReturnNewFirst_ReturnNewSize(int first, int middle,
            int last, int expectedNewSize, int expectedNewFirst)
        {
            _list.AddFirst(first);
            _list.AddLast(middle);
            _list.AddLast(last);

            _list.RemoveFirst();

            var sizeResult = _list.Size();
            var firstResult = _list.GetFirst();

            Assert.That(sizeResult, Is.EqualTo(expectedNewSize));
            Assert.That(firstResult, Is.EqualTo(expectedNewFirst));
        }

        [Test]
        [TestCase(10, 20, 30, 2, 20)]
        [TestCase(10, 50, 30, 2, 50)]
        public void RemoveLast_ReturnNewLast_ReturnNewSize(int first, int middle,
            int last, int expectedNewSize, int expectedNewLast)
        {
            _list.AddFirst(first);
            _list.AddLast(middle);
            _list.AddLast(last);

            _list.RemoveLast();

            var sizeResult = _list.Size();
            var lastResult = _list.GetLast();

            Assert.That(sizeResult, Is.EqualTo(expectedNewSize));
            Assert.That(lastResult, Is.EqualTo(expectedNewLast));
        }

        [Test]
        [TestCase(10, 20, 30, 30, 10)]
        [TestCase(20, 50, 30, 30, 20)]
        public void ReverseList_MultipleElements_ReturnNewFirst_ReturnNewLast(int first, int middle,
            int last, int expectedNewFirst, int expectedNewLast)
        {
            _list.AddFirst(first);
            _list.AddLast(middle);
            _list.AddLast(last);

            _list.Reverse();

            var firstResult = _list.GetFirst();
            var lastResult = _list.GetLast();

            Assert.That(firstResult, Is.EqualTo(expectedNewFirst));
            Assert.That(lastResult, Is.EqualTo(expectedNewLast));
        }

        [Test]
        [TestCase(10, 20, 30, 40, 2, 30)]
        [TestCase(10, 20, 30, 40, 1, 40)]
        [TestCase(10, 20, 30, 40, 4, 10)]
        [TestCase(10, 20, 30, 40, 3, 20)]
        public void GetKthFromTheEnd_MultipleElements_ReturnNodeValue(int first, int second,
            int third, int last, int k, int expectedResult)
        {
            _list.AddFirst(first);
            _list.AddLast(second);
            _list.AddLast(third);
            _list.AddLast(last);

            var result = _list.GetKthFromTheEnd(k);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

    }
}