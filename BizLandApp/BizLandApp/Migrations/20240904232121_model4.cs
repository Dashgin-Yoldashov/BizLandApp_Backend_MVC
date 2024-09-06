using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BizLandApp.Migrations
{
    /// <inheritdoc />
    public partial class model4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sectionHeaders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactHead = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaqHead = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutHead = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceHead = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PortfolioHead = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamHead = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PricingHead = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IFrameLink = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sectionHeaders", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sectionHeaders");
        }
    }
}
