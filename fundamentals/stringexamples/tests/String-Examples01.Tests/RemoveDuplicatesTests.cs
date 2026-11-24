
namespace String_Examples01.Tests
{
    public class RemoveDuplicatesTests
    {
        public RemoveDuplicatesTests()
        {
        }

        [Theory]
        [InlineData("hello", "helo")]
        [InlineData("Csharpstar", "Csharpt")]
        [InlineData("Mississippi", "Misp")]
        [InlineData("", "")]
        [InlineData("1234567890", "1234567890")]
        public void TestRemoveDuplicatesByCharacter(string input, string expectedOutput)
        {
            string actualOutput = RemoveDuplicates.RemoveDuplicatesByCharacter(input);
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Theory]
        [InlineData("hello", "helo")]
        [InlineData("Csharpstar", "Csharpt")]
        [InlineData("Mississippi", "Misp")]
        [InlineData("", "")]
        [InlineData("1234567890", "1234567890")]
        public void TestRemoveDuplicatesByHashSet(string input, string expectedOutput)
        {
            string actualOutput = RemoveDuplicates.RemoveDuplicatesByHashSet(input);
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Theory]
        [InlineData("hello", "helo")]
        [InlineData("Csharpstar", "Csharpt")]
        [InlineData("Mississippi", "Misp")]
        [InlineData("", "")]
        [InlineData("1234567890", "1234567890")]
        public void TestRemoveDuplicatesByDictionary(string input, string expectedOutput)
        {
            string actualOutput = RemoveDuplicates.RemoveDuplicatesByDictoinary(input);
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Theory]
        [InlineData("hello", "helo")]
        [InlineData("Csharpstar", "Csharpt")]
        [InlineData("Mississippi", "Misp")]
        [InlineData("", "")]
        [InlineData("1234567890", "1234567890")]
        public void TestRemoveDuplicatesByLinq(string input, string expectedOutput)
        {
            string actualOutput = RemoveDuplicates.RemoveDuplicatesByLinq(input);
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}