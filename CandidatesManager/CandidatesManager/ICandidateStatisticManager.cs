using System;
using System.Collections.Generic;

namespace CandidatesManager
{
    public interface ICandidateStatisticManager
    {
        IEnumerable<string> GetInvalidEntries();
        IEnumerable<Tuple<char, int>> GetLetterStatistic();
    }
}