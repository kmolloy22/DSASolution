using RemoveDuplicates_Example;

namespace Arrays_Examples.Tests
{
    [TestFixture]
    public class RemoveDuplicatesTests
    {
        private RemoveDuplicates _removeDuplicates;

        [SetUp]
        public void Setup()
        {
            _removeDuplicates = new RemoveDuplicates();
        }

        [Test]
        [TestCase(new object[] {1, 0, 1, 0}, new object[] {1, 0})]
        [TestCase(new object[] { "The", "Big", "Hat" }, new object[] { "The", "Big", "Hat" })]
        [TestCase(new object[] { "The", "Big", "Hat", "Big" }, new object[] { "The", "Big", "Hat" })]
        public void RemoveDuplicatesWithLinq_ReturnArray(object[] array, object[] expectedResult)
        {
            var result = _removeDuplicates.RemoveDupsWithLinq(array);

            Assert.That(result, Is.EquivalentTo(expectedResult));
        }

        [Test]
        [TestCase(new object[] { 1, 0, 1, 0 }, new object[] { 1, 0 })]
        [TestCase(new object[] { "The", "Big", "Hat" }, new object[] { "The", "Big", "Hat" })]
        [TestCase(new object[] { "The", "Big", "Hat", "Big" }, new object[] { "The", "Big", "Hat" })]
        public void RemoveDuplicates_ReturnArray(object[] array, object[] expectedResult)
        {
            var result = _removeDuplicates.RemoveDupsWithLinq(array);

            Assert.That(result, Is.EquivalentTo(expectedResult));
        }
    }
}
