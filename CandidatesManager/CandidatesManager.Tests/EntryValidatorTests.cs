using CandidatesManager.Library;
using NUnit.Framework;

namespace CandidatesManager.Tests
{
    [TestFixture]
    public class EntryValidatorTests
    {
        private IEntryValidator _entryValidator;

        [SetUp]
        public void Setup()
        {
            //creation of basic reusable default entities
            _entryValidator = new EntryValidator();
        }

        [Test]
        [TestCase("Newman, Paul")]
        [TestCase("De Niro, Robert")]
        [TestCase("Reese Whiterspoon, Laura Jeane")]
        public void EntryValidator_IsCorrect_CorrectEntry_ReturnsTrue(string entry)
        {
            var isEntryValid = _entryValidator.IsValid(entry);
            Assert.IsTrue(isEntryValid);
        }

        [Test]
        [TestCase("Newman, Paul, John")]
        [TestCase("De Niro , Robert")]
        [TestCase("De Niro ,Robert")]
        [TestCase("Reese Whiterspoon,, Laura Jeane")]
        [TestCase("Robert")]
        [TestCase("Robert,,")]
        public void EntryValidator_IsCorrect_IncorrectEntry_ReturnsFalse(string entry)
        {
            var isEntryValid = _entryValidator.IsValid(entry);
            Assert.IsFalse(isEntryValid);
        }
    }
}