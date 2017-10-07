using System.Text.RegularExpressions;

namespace CandidatesManager
{
    public class EntryValidator : IEntryValidator
    {
        private const string DefaultRegExpValidationPattern = @"^\w+(?<LastName>(\s)*\w+)+,\s(?<FirstName>\w+(\s)*\w+)+\z";
        private const string DefaultExtractionGroupName = "FirstName";

        public string RegExpValidationPattern { get; set; }
        public string ExtractionGroupName { get; set; }

        public EntryValidator()
        {
            RegExpValidationPattern = DefaultRegExpValidationPattern;
            ExtractionGroupName = DefaultExtractionGroupName;
        }
        
        public EntryValidator(string regexpValidationPattern, string extractionGroupName)
        {
            RegExpValidationPattern = regexpValidationPattern;
            ExtractionGroupName = extractionGroupName;
        }
        
        public bool IsValid(string entry)
        {
            return Regex.IsMatch(entry, RegExpValidationPattern);  
        }

        public string GetMatch(string entry)
        {
            return Regex.Match(entry, RegExpValidationPattern).Groups[ExtractionGroupName].ToString();
        }

    }
}