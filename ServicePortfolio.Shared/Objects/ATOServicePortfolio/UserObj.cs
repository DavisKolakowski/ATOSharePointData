using Newtonsoft.Json;

namespace ServicePortfolio.Shared.Objects.ATOServicePortfolio
{
    public class UserObj
    {
        public string DisplayName { get; set; } = String.Empty;

        public string Email { get; set; } = String.Empty;

        [JsonProperty("id")]
        public string UserIdentifier { get; set; } = String.Empty;
    }

}