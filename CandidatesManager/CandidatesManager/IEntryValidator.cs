namespace CandidatesManager
{
    public interface IEntryValidator
    {
        string RegExpValidationPattern { get; set; }

        bool IsValid(string entry);

        string GetMatch(string entry);
    }
}