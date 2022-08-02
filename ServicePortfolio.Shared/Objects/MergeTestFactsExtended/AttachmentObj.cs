using Newtonsoft.Json; 
using System; 
namespace ServicePortfolio.Shared.Objects.MergeTestFactsExtended{ 

    public class AttachmentObj
    {
        [JsonProperty("content_type")]
        public string ContentType { get; set; } = String.Empty;

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; } = String.Empty;

        [JsonProperty("file_name")]
        public string FileName { get; set; } = String.Empty;

        [JsonProperty("file_size")]
        public int FileSize { get; set; }

        public string Id { get; set; } = String.Empty;

        [JsonProperty("original_file_size")]
        public int OriginalFileSize { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }

}