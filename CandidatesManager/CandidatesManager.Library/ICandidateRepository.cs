using System.Collections.Generic;

namespace CandidatesManager.Library
{
    public interface ICandidateRepository
    {
        IEnumerable<string> GetEntries();
    }
}