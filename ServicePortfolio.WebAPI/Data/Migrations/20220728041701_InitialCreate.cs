using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServicePortfolio.WebAPI.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContentTypes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CreatedBy",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatedBy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreatedBy_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LastModifiedBy",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LastModifiedBy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LastModifiedBy_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Values",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Attachments = table.Column<bool>(type: "bit", nullable: false),
                    AuthorLookupId = table.Column<int>(type: "int", nullable: false),
                    ContentTypeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Edit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EditorLookupId = table.Column<int>(type: "int", nullable: false),
                    FolderChildCount = table.Column<int>(type: "int", nullable: false),
                    FunctionX0020X0028AnX0020A = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemChildCount = table.Column<int>(type: "int", nullable: false),
                    LOE = table.Column<int>(type: "int", nullable: false),
                    LinkTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkTitleNoMenu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Practice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimaryService = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceCategory2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupportedProductL1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Team = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComplianceFlags = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComplianceTag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComplianceTagUserIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComplianceTagWrittenTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UIVersionString = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedById = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LastModifiedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Values", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Values_ContentTypes_ContentTypeId",
                        column: x => x.ContentTypeId,
                        principalTable: "ContentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Values_CreatedBy_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "CreatedBy",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Values_LastModifiedBy_LastModifiedById",
                        column: x => x.LastModifiedById,
                        principalTable: "LastModifiedBy",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SupportedProductL2s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValueId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportedProductL2s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SupportedProductL2s_Values_ValueId",
                        column: x => x.ValueId,
                        principalTable: "Values",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ToolsUsed",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValueId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToolsUsed", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ToolsUsed_Values_ValueId",
                        column: x => x.ValueId,
                        principalTable: "Values",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CreatedBy_UserId",
                table: "CreatedBy",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LastModifiedBy_UserId",
                table: "LastModifiedBy",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportedProductL2s_ValueId",
                table: "SupportedProductL2s",
                column: "ValueId");

            migrationBuilder.CreateIndex(
                name: "IX_ToolsUsed_ValueId",
                table: "ToolsUsed",
                column: "ValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Values_ContentTypeId",
                table: "Values",
                column: "ContentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Values_CreatedById",
                table: "Values",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Values_LastModifiedById",
                table: "Values",
                column: "LastModifiedById");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupportedProductL2s");

            migrationBuilder.DropTable(
                name: "ToolsUsed");

            migrationBuilder.DropTable(
                name: "Values");

            migrationBuilder.DropTable(
                name: "ContentTypes");

            migrationBuilder.DropTable(
                name: "CreatedBy");

            migrationBuilder.DropTable(
                name: "LastModifiedBy");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
