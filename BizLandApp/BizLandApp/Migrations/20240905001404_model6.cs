using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BizLandApp.Migrations
{
    /// <inheritdoc />
    public partial class model6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "products");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "products");
        }
    }
}
