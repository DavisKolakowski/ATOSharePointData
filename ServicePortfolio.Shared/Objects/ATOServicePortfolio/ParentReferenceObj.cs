using Newtonsoft.Json;

namespace ServicePortfolio.Shared.Objects.ATOServicePortfolio
{
    public class ParentReferenceObj
    {
        [JsonProperty("siteId")]
        public string SiteIdentifier { get; set; } = String.Empty;
    }
}