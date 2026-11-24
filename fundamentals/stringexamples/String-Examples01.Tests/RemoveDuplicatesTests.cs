
namespace String_Examples01.Tests
{
    [TestFixture]
    public class RemoveDuplicatesTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("hello", "helo")]
        [TestCase("Csharpstar", "Csharpt")]
        [TestCase("Mississippi", "Misp")]
        [TestCase("", "")]
        [TestCase("1234567890", "1234567890")]
        public void TestRemoveDuplicatesByCharacter(string input, string expectedOutput)
        {
            string actualOutput = RemoveDuplicates.RemoveDuplicatesByCharacter(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestCase("hello", "helo")]
        [TestCase("Csharpstar", "Csharpt")]
        [TestCase("Mississippi", "Misp")]
        [TestCase("", "")]
        [TestCase("1234567890", "1234567890")]
        public void TestRemoveDuplicatesByHashSet(string input, string expectedOutput)
        {
            string actualOutput = RemoveDuplicates.RemoveDuplicatesByHashSet(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestCase("hello", "helo")]
        [TestCase("Csharpstar", "Csharpt")]
        [TestCase("Mississippi", "Misp")]
        [TestCase("", "")]
        [TestCase("1234567890", "1234567890")]
        public void TestRemoveDuplicatesByDictionary(string input, string expectedOutput)
        {
            string actualOutput = RemoveDuplicates.RemoveDuplicatesByDictoinary(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestCase("hello", "helo")]
        [TestCase("Csharpstar", "Csharpt")]
        [TestCase("Mississippi", "Misp")]
        [TestCase("", "")]
        [TestCase("1234567890", "1234567890")]
        public void TestRemoveDuplicatesByLinq(string input, string expectedOutput)
        {
            string actualOutput = RemoveDuplicates.RemoveDuplicatesByLinq(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}