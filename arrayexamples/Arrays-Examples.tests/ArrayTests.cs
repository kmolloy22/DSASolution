namespace Arrays_Examples.tests
{
    [TestFixture]
    public class ArrayTests
    {
        [Test]
        public void Insert_WithInitialCapacity_InsertsNumber()
        {
            // Arrange
            var array = new Arrays_Example01.Array(1);

            // Act
            array.Insert(5);
            var items = array.Items();

            // Assert
            Assert.AreEqual(1, array.Count());
            Assert.AreEqual(5, items[0]);
        }

        [Test]
        public void Insert_WithFullCapacity_ResizesArray()
        {
            // Arrange
            var array = new Arrays_Example01.Array(1);
            array.Insert(5);

            // Act
            array.Insert(10);
            var items = array.Items();

            // Assert
            Assert.AreEqual(2, array.Count());
            Assert.AreEqual(5, items[0]);
            Assert.AreEqual(10, items[1]);
        }

        [Test]
        public void Insert_WithMultipleInserts_MaintainsOrder()
        {
            // Arrange
            var array = new Arrays_Example01.Array(3);

            // Act
            array.Insert(5);
            array.Insert(10);
            array.Insert(15);
            var items = array.Items();

            // Assert
            Assert.AreEqual(3, array.Count());
            Assert.AreEqual(5, items[0]);
            Assert.AreEqual(10, items[1]);
            Assert.AreEqual(15, items[2]);
        }

        [Test]
        public void ResizeIfRequired_WithFullCapacity_ResizesArray()
        {
            // Arrange
            var array = new Arrays_Example01.Array(3);

            // Act
            array.Insert(5);
            array.Insert(10);
            array.Insert(15);
            array.Insert(20);
            array.Insert(25);
            array.Insert(30);
            var items = array.Items();

            // Assert
            Assert.AreEqual(6, array.Count());
            Assert.AreEqual(5, items[0]);
            Assert.AreEqual(10, items[1]);
            Assert.AreEqual(15, items[2]);
            Assert.AreEqual(20, items[3]);
            Assert.AreEqual(25, items[4]);
            Assert.AreEqual(30, items[5]);
        }

        [Test]
        public void RemoveAt_WithValidIndex_RemovesItem()
        {
            // Arrange
            var array = new Arrays_Example01.Array(3);
            array.Insert(5);
            array.Insert(10);
            array.Insert(15);

            // Act
            array.RemoveAt(1);
            var items = array.Items();

            // Assert
            Assert.AreEqual(2, array.Count());
            Assert.AreEqual(5, items[0]);
            Assert.AreEqual(15, items[1]);
        }
    }
}