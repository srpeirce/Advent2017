using Xunit;

namespace Day4.Tests
{
    public class PassPhraseTests
    {
        [Theory,
            InlineData("aa bb cc dd ee", true),
            InlineData("aa bb cc dd aa", false),
            InlineData("aa bb cc dd aaa", true),
            InlineData("abcde fghij", true),
            InlineData("abcde xyz ecdab", false),
            InlineData("a ab abc abd abf abj", true),
            InlineData("iiii oiii ooii oooi oooo", true),
            InlineData("oiii ioii iioi iiio", false)]
        public void Validate(string value, bool expected)
        {
            var actual = PassPhrase.TryParse(value, out var passPhrase);
            Assert.Equal(expected, actual);
        }
    }
}
