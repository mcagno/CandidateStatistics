namespace CandidatesManager.Library
{
    public interface IEntryValidator
    {
        string RegExpValidationPattern { get; set; }

        bool IsValid(string entry);

        string GetMatch(string entry);
    }
}