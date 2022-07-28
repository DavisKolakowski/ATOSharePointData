namespace ServicePortfolio.WebAPI.Models
{
    public class Value
    {
        public int Id { get; set; }
        
        public bool Attachments { get; set; }

        public int AuthorLookupId { get; set; }

        public ContentType? ContentType { get; set; }

        public DateTime Created { get; set; }

        public string Edit { get; set; } = String.Empty;

        public int EditorLookupId { get; set; }

        public int FolderChildCount { get; set; }

        public string FunctionX0020X0028AnX0020A { get; set; } = String.Empty;

        public int ItemChildCount { get; set; }

        public int LOE { get; set; }

        public string LinkTitle { get; set; } = String.Empty;

        public string LinkTitleNoMenu { get; set; } = String.Empty;

        public DateTime Modified { get; set; }

        public string Practice { get; set; } = String.Empty;

        public string PrimaryService { get; set; } = String.Empty;

        public string ServiceCategory2 { get; set; } = String.Empty;

        public string Status { get; set; } = String.Empty;

        public string SupportedProductL1 { get; set; } = String.Empty;

        public string Team { get; set; } = String.Empty;

        public string Title { get; set; } = String.Empty;

        public List<ToolUsed> ToolsUsed { get; set; } = new List<ToolUsed>();

        public string ComplianceFlags { get; set; } = String.Empty;

        public string ComplianceTag { get; set; } = String.Empty;

        public string ComplianceTagUserIdentifier { get; set; } = String.Empty;

        public string ComplianceTagWrittenTime { get; set; } = String.Empty;

        public string UIVersionString { get; set; } = String.Empty;

        public List<SupportedProductL2> SupportedProductL2s { get; set; } = new List<SupportedProductL2>();

        public CreatedBy? CreatedBy { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public LastModifiedBy? LastModifiedBy { get; set; }

        public DateTime LastModifiedDateTime { get; set; }
    }

    public class ContentType
    {
        public string Id { get; set; }

        public string Name { get; set; } = String.Empty;
    }

    public class CreatedBy
    {
        public string Id { get; set; }

        public User User { get; set; } = new User();
    }

    public class ToolUsed
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
    }

    public class SupportedProductL2
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
    }

    public class LastModifiedBy
    {
        public string Id { get; set; }

        public User User { get; set; } = new User();
    }

    public class User
    {
        public string Id { get; set; }

        public string DisplayName { get; set; } = String.Empty;

        public string Email { get; set; } = String.Empty;

        //public string UserIdentifier { get; set; } = String.Empty;
    }
}
