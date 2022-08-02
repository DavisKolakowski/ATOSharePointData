using Dapper;

using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

using Newtonsoft.Json;

using Serilog;

using ServicePortfolio.Shared.Objects.ATOServicePortfolio;
using ServicePortfolio.Shared.Services;

using System.Net.Mail;
using System.Security.Cryptography.Xml;

namespace ServicePortfolio.Service
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                            .AddJsonFile("appsettings.json")
                            .AddUserSecrets<Program>()
                            .Build();

            Log.Logger = new LoggerConfiguration()
                            .WriteTo.Console()
                            .CreateLogger();

            Log.Information("Application Starting");

            var conString = config.GetConnectionString("ATOServicePortfolioSQLDevelopmentDatabase");
            var conn = new SqlConnection(conString);

            var servicePortfolioObjRootObj = ATOServicePortfolioDeserializeService.DeserializeJson();

            foreach (var obj in servicePortfolioObjRootObj.Value)
            {
                //Load Json into DB Logic
                //conn.Execute($"INSERT INTO [dbo].[Values]([Attachments], [AuthorLookupId], [ContentTypeId], [Created], [Edit], [EditorLookupId], [FolderChildCount], [FunctionX0020X0028AnX0020A], [ItemChildCount], [LOE], [LinkTitle], [LinkTitleNoMenu], [Modified], [Practice], [PrimaryService], [ServiceCategory2], [Status], [SupportedProductL1], [Team], [Title], [ComplianceFlags], [ComplianceTag], [ComplianceTagUserIdentifier], [ComplianceTagWrittenTime], [UIVersionString], [CreatedById], [CreatedDateTime], [LastModifiedById], [LastModifiedDateTime]) VALUES (@Attachments, @AuthorLookupId, @ContentTypeId, @Created, @Edit, @EditorLookupId, @FolderChildCount, @FunctionX0020X0028AnX0020A, @ItemChildCount, @LOE, @LinkTitle, @LinkTitleNoMenu, @Modified, @Practice, @PrimaryService, @ServiceCategory2, @Status, @SupportedProductL1, @Team, @Title, @ComplianceFlags, @ComplianceTag, @ComplianceTagUserIdentifier, @ComplianceTagWrittenTime, @UIVersionString, @CreatedById, @CreatedDateTime, @LastModifiedById, @LastModifiedDateTime);",
                conn.Execute($"INSERT INTO [dbo].[Values]([Attachments], [AuthorLookupId], [Created], [Edit], [EditorLookupId], [FolderChildCount], [FunctionX0020X0028AnX0020A], [ItemChildCount], [LOE], [LinkTitle], [LinkTitleNoMenu], [Modified], [Practice], [PrimaryService], [ServiceCategory2], [Status], [SupportedProductL1], [Team], [Title], [ComplianceFlags], [ComplianceTag], [ComplianceTagUserIdentifier], [ComplianceTagWrittenTime], [UIVersionString], [CreatedDateTime], [LastModifiedDateTime]) VALUES (@Attachments, @AuthorLookupId, @Created, @Edit, @EditorLookupId, @FolderChildCount, @FunctionX0020X0028AnX0020A, @ItemChildCount, @LOE, @LinkTitle, @LinkTitleNoMenu, @Modified, @Practice, @PrimaryService, @ServiceCategory2, @Status, @SupportedProductL1, @Team, @Title, @ComplianceFlags, @ComplianceTag, @ComplianceTagUserIdentifier, @ComplianceTagWrittenTime, @UIVersionString, @CreatedDateTime, @LastModifiedDateTime);",
                    new
                    {
                        Attachments = obj.Fields.Attachments,
                        AuthorLookupId = obj.Fields.AuthorLookupId,
                        //ContentTypeId = obj.ContentType.ContentIdentifier,
                        Created = obj.Fields.Created,
                        Edit = obj.Fields.Edit,
                        EditorLookupId = obj.Fields.EditorLookupId,
                        FolderChildCount = obj.Fields.FolderChildCount,
                        FunctionX0020X0028AnX0020A = obj.Fields.FunctionX0020X0028AnX0020A,
                        ItemChildCount = obj.Fields.ItemChildCount,
                        LOE = obj.Fields.LOE,
                        LinkTitle = obj.Fields.LinkTitle,
                        LinkTitleNoMenu = obj.Fields.LinkTitleNoMenu,
                        Modified = obj.Fields.Modified,
                        Practice = obj.Fields.Practice,
                        PrimaryService = obj.Fields.PrimaryService,
                        ServiceCategory2 = obj.Fields.ServiceCategory2,
                        Status = obj.Fields.Status,
                        SupportedProductL1 = obj.Fields.SupportedProductL1,
                        Team = obj.Fields.Team,
                        Title = obj.Fields.Title,
                        ComplianceFlags = obj.Fields.ComplianceFlags,
                        ComplianceTag = obj.Fields.ComplianceTag,
                        ComplianceTagUserIdentifier = obj.Fields.ComplianceTagUserIdentifier,
                        ComplianceTagWrittenTime = obj.Fields.ComplianceTagWrittenTime,
                        UIVersionString = obj.Fields.UIVersionString,
                        //CreatedById = obj.CreatedBy.User.UserIdentifier,
                        CreatedDateTime = obj.CreatedDateTime,
                        //LastModifiedById = obj.LastModifiedBy.User.UserIdentifier,
                        LastModifiedDateTime = obj.LastModifiedDateTime,
                    });
            }

            var mergeTestFactsExtendedRootObj = MergeTestFactsExtendedDeserializeService.DeserializeJson();
            foreach (var obj in mergeTestFactsExtendedRootObj)
            {
                //db update logic
            }
        }
    }
}