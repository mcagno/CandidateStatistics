using System;
using System.Collections.Generic;
using System.Linq;

namespace CandidatesManager.Library
{
    public class CandidateStatisticManager : ICandidateStatisticManager
    {
        private readonly ICandidateRepository _repository;
        private readonly IEntryValidator _entryValidator;

        public CandidateStatisticManager(ICandidateRepository repository, IEntryValidator entryValidator)
        {
            _repository = repository;
            _entryValidator = entryValidator;
        }

        public IEnumerable<string> GetInvalidEntries()
        {
            return from entry in _repository.GetEntries()
                where !_entryValidator.IsValid(entry)
                   select entry;
        }

        private IEnumerable<string> GetValidEntries()
        {
            return from entry in _repository.GetEntries()
                where _entryValidator.IsValid(entry)
                select entry;
        }

        public IEnumerable<Tuple<char, int>> GetLetterStatistic()
        {
            var cleanList = GetValidEntries();
            var x = cleanList
                .Select(e => _entryValidator.GetMatch(e))
                .Distinct()
                .GroupBy(l => l[0], (key, g) => new Tuple<char, int>(key, g.Count()))
                .OrderBy(t => t.Item1);
            return x;
            
        }
    }
}
