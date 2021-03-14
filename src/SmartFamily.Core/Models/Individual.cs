using System.Numerics;

namespace SmartFamily.Core.Models
{
    public class Individual
    {
        public string? IndividualID { get; set; }

        public string? GivenName { get; set; }

        public string? Surname { get; set; }

        public string? Gender { get; set; }

        public string? Occupation { get; set; }

        public string? Relation { get; set; }

        public string? RelationToRoot { get; set; }

        public string? Title { get; set; }

        public string? Suffix { get; set; }

        public string? Alias { get; set; }

        public string? FamilySearchID { get; }

        public int MarriageCount { get; set; }

        public int ChildrenCount { get; set; }

        public string? BudgieCode { get; set; }

        public BigInteger Ahnentafel { get; set; }

        public bool HasNotes { get; set; }

        public int FactsCount { get; set; }

        public int SourcesCount { get; set; }
    }
}