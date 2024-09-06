using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BizLandApp.Migrations
{
    /// <inheritdoc />
    public partial class category : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_categories_CategoriesId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_CategoriesId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "FilterName",
                table: "products");

            migrationBuilder.AlterColumn<string>(
                name: "CategoriesId",
                table: "products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CategoriesId1",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_products_CategoriesId1",
                table: "products",
                column: "CategoriesId1");

            migrationBuilder.AddForeignKey(
                name: "FK_products_categories_CategoriesId1",
                table: "products",
                column: "CategoriesId1",
                principalTable: "categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_categories_CategoriesId1",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_CategoriesId1",
                table: "products");

            migrationBuilder.DropColumn(
                name: "CategoriesId1",
                table: "products");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriesId",
                table: "products",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "FilterName",
                table: "products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_products_CategoriesId",
                table: "products",
                column: "CategoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_categories_CategoriesId",
                table: "products",
                column: "CategoriesId",
                principalTable: "categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
