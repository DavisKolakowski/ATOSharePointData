using Newtonsoft.Json;

namespace ServicePortfolio.Shared.Objects.ATOServicePortfolio
{
    public class ContentTypeObj
    {
        [JsonProperty("id")]
        public string ContentIdentifier { get; set; } = String.Empty;

        public string Name { get; set; } = String.Empty;
    }

}