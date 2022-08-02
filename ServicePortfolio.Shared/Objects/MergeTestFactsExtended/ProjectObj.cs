using Newtonsoft.Json; 
using System.Collections.Generic; 
using System; 
namespace ServicePortfolio.Shared.Objects.MergeTestFactsExtended{ 

    public class ProjectObj
    {
        public string Key { get; set; } = string.Empty;

        public string Type { get; set; } = string.Empty;

        public DateTime UpdatedAt { get; set; }

        public List<string> Value { get; set; } = new List<string>();
    }

}