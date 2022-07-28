using Newtonsoft.Json;

using ServicePortfolio.Shared.Objects.ATOServicePortfolio;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicePortfolio.Shared.Services
{
    public class ATOServicePortfolioDeserializeService
    {
        public static JSONMapperRootObj DeserializeJson()
        {
            var jsonString = File.ReadAllText(@"C:\Users\dkolak713\repos\ATOSharePointData\ServicePortfolio.Shared\Data\ATOServicePortfolio.json");

            var rootObj = JsonConvert.DeserializeObject<JSONMapperRootObj>(jsonString);

            return rootObj;
        }
    }
}
