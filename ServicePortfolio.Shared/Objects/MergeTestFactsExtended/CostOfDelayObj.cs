using Newtonsoft.Json; 
using System.Collections.Generic; 
using System; 
namespace ServicePortfolio.Shared.Objects.MergeTestFactsExtended{ 

    public class CostOfDelayObj
    {
        public string Key { get; set; } = String.Empty;

        [JsonProperty("score_facts")]
        public List<ScoreFactObj> ScoreFacts { get; set; } = new List<ScoreFactObj>();

        public string Type { get; set; } = String.Empty;

        public DateTime UpdatedAt { get; set; }

        public int Value { get; set; }
    }

}