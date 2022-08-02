using Newtonsoft.Json;
using ServicePortfolio.Shared.Objects.ATOServicePortfolio;
using ServicePortfolio.Shared.Objects.MergeTestFactsExtended;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicePortfolio.Shared.Services
{
    public class MergeTestFactsExtendedDeserializeService
    {
        public static List<JSONMapperRootMergeTestFactsExtendedObj> DeserializeJson()
        {
            var jsonString = File.ReadAllText(@"C:\Users\dkolak713\repos\ATOSharePointData\ServicePortfolio.Shared\Data\merge_test_facts_Extended.json");

            var rootObj = JsonConvert.DeserializeObject<List<JSONMapperRootMergeTestFactsExtendedObj>>(jsonString);

            return rootObj;
        }
    }
}
