namespace ServicePortfolio.Shared.Objects.ATOServicePortfolio
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System;
using System.Text.Json.Serialization;

    public class FieldsObj
    {
        public int Id { get; set; }

        [JsonProperty("@odata.etag")]
        public string OdataEtag { get; set; } = String.Empty;      
        
        public bool Attachments { get; set; }       
        
        public int AuthorLookupId { get; set; }       
        
        public string ContentType { get; set; } = String.Empty;       
        
        public DateTime Created { get; set; }       
        
        public string Edit { get; set; } = String.Empty;        
        
        public int EditorLookupId { get; set; }      
        
        public int FolderChildCount { get; set; }

        [JsonProperty("Function_x0020__x0028_An_x0020_a")]
        public string FunctionX0020X0028AnX0020A { get; set; } = String.Empty;
        
        public int ItemChildCount { get; set; }
        
        public int LOE { get; set; }
        
        public string LinkTitle { get; set; } = String.Empty;
        
        public string LinkTitleNoMenu { get; set; } = String.Empty;        
        
        public DateTime Modified { get; set; }
               
        public string Practice { get; set; } = String.Empty;

        [JsonProperty("Primary_Service")]
        public string PrimaryService { get; set; } = String.Empty;

        [JsonProperty("Service_Category_2")]
        public string ServiceCategory2 { get; set; } = String.Empty;       
        
        public string Status { get; set; } = String.Empty;

        [JsonProperty("Supported_Product_L1")]
        public string SupportedProductL1 { get; set; } = String.Empty;        
        
        public string Team { get; set; } = String.Empty;        
        
        public string Title { get; set; } = String.Empty;

        [JsonProperty("Tools_Used")]
        public List<string> ToolsUsed { get; set; } = new List<string>();

        [JsonProperty("_ComplianceFlags")]
        public string ComplianceFlags { get; set; } = String.Empty;

        [JsonProperty("_ComplianceTag")]
        public string ComplianceTag { get; set; } = String.Empty;

        [JsonProperty("_ComplianceTagUserId")]
        public string ComplianceTagUserIdentifier { get; set; } = String.Empty;

        [JsonProperty("_ComplianceTagWrittenTime")]
        public string ComplianceTagWrittenTime { get; set; } = String.Empty;

        [JsonProperty("_UIVersionString")]
        public string UIVersionString { get; set; } = String.Empty;

        [JsonProperty("Supported_Product_L2")]
        public List<string> SupportedProductL2s { get; set; } = new List<string>();
    }

}