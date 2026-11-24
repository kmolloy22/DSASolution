namespace Arrays_Examples.Tests
{
    public class ArrayTests
    {
        [Fact]
        public void Insert_WithInitialCapacity_InsertsNumber()
        {
            // Arrange
            var array = new Arrays_Example01.Array(1);

            // Act
            array.Insert(5);
            var items = array.Items();

            // Assert
            Assert.Equal(1, array.Count());
            Assert.Equal(5, items[0]);
        }

        [Fact]
        public void Insert_WithFullCapacity_ResizesArray()
        {
            // Arrange
            var array = new Arrays_Example01.Array(1);
            array.Insert(5);

            // Act
            array.Insert(10);
            var items = array.Items();

            // Assert
            Assert.Equal(2, array.Count());
            Assert.Equal(5, items[0]);
            Assert.Equal(10, items[1]);
        }

        [Fact]
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
            Assert.Equal(3, array.Count());
            Assert.Equal(5, items[0]);
            Assert.Equal(10, items[1]);
            Assert.Equal(15, items[2]);
        }

        [Fact]
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
            Assert.Equal(6, array.Count());
            Assert.Equal(5, items[0]);
            Assert.Equal(10, items[1]);
            Assert.Equal(15, items[2]);
            Assert.Equal(20, items[3]);
            Assert.Equal(25, items[4]);
            Assert.Equal(30, items[5]);
        }

        [Fact]
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
            Assert.Equal(2, array.Count());
            Assert.Equal(5, items[0]);
            Assert.Equal(15, items[1]);
        }
    }
}