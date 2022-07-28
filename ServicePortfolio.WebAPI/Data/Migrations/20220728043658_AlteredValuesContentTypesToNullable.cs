using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServicePortfolio.WebAPI.Data.Migrations
{
    public partial class AlteredValuesContentTypesToNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Values_ContentTypes_ContentTypeId",
                table: "Values");

            migrationBuilder.AlterColumn<string>(
                name: "ContentTypeId",
                table: "Values",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Values_ContentTypes_ContentTypeId",
                table: "Values",
                column: "ContentTypeId",
                principalTable: "ContentTypes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Values_ContentTypes_ContentTypeId",
                table: "Values");

            migrationBuilder.AlterColumn<string>(
                name: "ContentTypeId",
                table: "Values",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Values_ContentTypes_ContentTypeId",
                table: "Values",
                column: "ContentTypeId",
                principalTable: "ContentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
