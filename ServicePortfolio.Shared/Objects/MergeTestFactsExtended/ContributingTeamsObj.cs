using Newtonsoft.Json; 
using System.Collections.Generic; 
using System; 
namespace ServicePortfolio.Shared.Objects.MergeTestFactsExtended{ 

    public class ContributingTeamsObj
    {
        public string Key { get; set; } = String.Empty;

        public string Type { get; set; } = String.Empty;

        public DateTime UpdatedAt { get; set; }

        public List<string> Value { get; set; } = new List<string>();
    }

}