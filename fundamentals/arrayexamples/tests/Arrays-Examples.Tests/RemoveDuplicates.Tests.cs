using RemoveDuplicates_Example;

namespace Arrays_Examples.Tests
{
    public class RemoveDuplicatesTests
    {
        private RemoveDuplicates _removeDuplicates;

        public RemoveDuplicatesTests()
        {
            _removeDuplicates = new RemoveDuplicates();
        }

        [Theory]
        [InlineData(new object[] {1, 0, 1, 0}, new object[] {1, 0})]
        [InlineData(new object[] { "The", "Big", "Hat" }, new object[] { "The", "Big", "Hat" })]
        [InlineData(new object[] { "The", "Big", "Hat", "Big" }, new object[] { "The", "Big", "Hat" })]
        public void RemoveDuplicatesWithLinq_ReturnArray(object[] array, object[] expectedResult)
        {
            var result = _removeDuplicates.RemoveDupsWithLinq(array);

            Assert.Equivalent(expectedResult, result);
        }

        [Theory]
        [InlineData(new object[] { 1, 0, 1, 0 }, new object[] { 1, 0 })]
        [InlineData(new object[] { "The", "Big", "Hat" }, new object[] { "The", "Big", "Hat" })]
        [InlineData(new object[] { "The", "Big", "Hat", "Big" }, new object[] { "The", "Big", "Hat" })]
        public void RemoveDuplicates_ReturnArray(object[] array, object[] expectedResult)
        {
            var result = _removeDuplicates.RemoveDupsWithLinq(array);

            Assert.Equivalent(expectedResult, result);
        }
    }
}
