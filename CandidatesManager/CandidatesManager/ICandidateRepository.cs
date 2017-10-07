using System.Collections.Generic;

namespace CandidatesManager
{
    public interface ICandidateRepository
    {
        IEnumerable<string> GetEntries();
    }
}