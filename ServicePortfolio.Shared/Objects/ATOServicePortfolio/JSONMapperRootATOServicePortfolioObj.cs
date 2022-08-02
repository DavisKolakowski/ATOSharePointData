namespace ServicePortfolio.Shared.Objects.ATOServicePortfolio
{
    using Newtonsoft.Json;

    using System.Collections.Generic;

    public class JSONMapperRootATOServicePortfolioObj
    {
        [JsonProperty("@odata.context")]
        public string OdataContext { get; set; } = String.Empty;

        public List<ValueObj> Value { get; set; } = new List<ValueObj>();
    }
}