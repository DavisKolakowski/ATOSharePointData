using Newtonsoft.Json; 
using System; 
namespace ServicePortfolio.Shared.Objects.MergeTestFactsExtended{ 

    public class StackRankObj
    {
        public string Key { get; set; } = String.Empty;

        public string Type { get; set; } = String.Empty;

        public DateTime UpdatedAt { get; set; }

        public string Value { get; set; } = String.Empty;
    }

}