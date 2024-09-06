using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BizLandApp.Migrations
{
    /// <inheritdoc />
    public partial class model3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Text",
                table: "teams");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "teams");

            migrationBuilder.DropColumn(
                name: "HeadText",
                table: "services");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "pricings");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "pricings");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "faqs");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "faqs");

            migrationBuilder.DropColumn(
                name: "IFrameLink",
                table: "contactheads");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "contactheads");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "abouts");

            migrationBuilder.RenameColumn(
                name: "SubNsmeText",
                table: "abouts",
                newName: "Image");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "abouts",
                newName: "SubNsmeText");

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "teams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HeadText",
                table: "services",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "pricings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "pricings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "faqs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "faqs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IFrameLink",
                table: "contactheads",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "contactheads",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
