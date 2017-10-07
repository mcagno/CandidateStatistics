using System.Linq;
using NSubstitute;
using NUnit.Framework;

namespace CandidatesManager.Tests
{
    [TestFixture]
    public class CandidateStatisticManagerTests
    {
        private IEntryValidator _entryValidator;

        [SetUp]
        public void Setup()
        {
            _entryValidator = new EntryValidator();
        }


        [Test]
        public void CalendarStatistManager_GetInvalidEntries_ContainsInvalid()
        {
            var mockedRepository = Substitute.For<ICandidateRepository>();
            mockedRepository.GetEntries().Returns(new[] { "Newman, Paul, John", "De Niro, Robert", "Reese Whiterspoon,, Laura Jeane"});
            var manager = new CandidateStatisticManager(mockedRepository, _entryValidator);
            var invalidEntries = manager.GetInvalidEntries().ToList();
            Assert.IsTrue(invalidEntries.Contains("Newman, Paul, John"));
            Assert.IsTrue(invalidEntries.Contains("Reese Whiterspoon,, Laura Jeane"));
        }

        [Test]
        public void CalendarStatistManager_GetInvalidEntries_NotContainsValid()
        {
            var mockedRepository = Substitute.For<ICandidateRepository>();
            mockedRepository.GetEntries().Returns(new[] { "Newman, Paul, John", "De Niro, Robert", "Reese Whiterspoon,, Laura Jeane" });
            var manager = new CandidateStatisticManager(mockedRepository, _entryValidator);
            var invalidEntries = manager.GetInvalidEntries();
            Assert.IsFalse(invalidEntries.Contains("De Niro, Robert"));
        }

        [Test]
        public void CalendarStatistManager_GetLetterStatistic_SimpleEntry()
        {
            var mockedRepository = Substitute.For<ICandidateRepository>();
            mockedRepository.GetEntries().Returns(new[] { "Newman, Paul, John", "De Niro, Robert", "Reese Whiterspoon,, Laura Jeane" });
            var manager = new CandidateStatisticManager(mockedRepository, _entryValidator);
            var statisticResult = manager.GetLetterStatistic().ToList();
            Assert.AreEqual(1, statisticResult.Count);
            Assert.AreEqual('R', statisticResult.First().Item1);
            Assert.AreEqual(1, statisticResult.First().Item2);
        }

        [Test]
        public void CalendarStatistManager_GetLetterStatistic_DuplicateEntriesNotCounted()
        {
            var mockedRepository = Substitute.For<ICandidateRepository>();
            mockedRepository.GetEntries().Returns(new[] { "Newman, Paul, John", "De Niro, Robert", "Reese Whiterspoon,, Laura Jeane", "Redford, Robert" });
            var manager = new CandidateStatisticManager(mockedRepository, _entryValidator);
            var statisticResult = manager.GetLetterStatistic().ToList();
            Assert.AreEqual(1, statisticResult.Count);
            Assert.AreEqual('R', statisticResult.First().Item1);
            Assert.AreEqual(1, statisticResult.First().Item2);
        }

        [Test]
        public void CalendarStatistManager_GetLetterStatistic_StressTest()
        {
            var repository = new DummyCandidateRepository(); //Since this instance contains fixed well know values, it is used as a stub
            CandidateStatisticManager manager = new CandidateStatisticManager(repository, _entryValidator);
            var letterStatistic = manager.GetLetterStatistic().ToList();
            Assert.AreEqual(2, letterStatistic.First(x => x.Item1 == 'A').Item2);
            Assert.AreEqual(6, letterStatistic.First(x => x.Item1 == 'B').Item2);
            Assert.AreEqual(1, letterStatistic.First(x => x.Item1 == 'J').Item2);
        }

    }
}
