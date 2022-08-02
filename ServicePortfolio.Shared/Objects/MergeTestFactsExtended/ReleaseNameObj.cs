using Newtonsoft.Json; 
using System.Collections.Generic; 
using System; 
namespace ServicePortfolio.Shared.Objects.MergeTestFactsExtended{ 

    public class ReleaseNameObj
    {
        public List<AttachmentObj> Attachments { get; set; } = new List<AttachmentObj>();

        public string Body { get; set; } = string.Empty;

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        public string Id { get; set; } = string.Empty;

        public string Key { get; set; } = string.Empty;

        public string Type { get; set; } = string.Empty;

        public DateTime UpdatedAt { get; set; }

        public string Value { get; set; } = string.Empty;
    }

}