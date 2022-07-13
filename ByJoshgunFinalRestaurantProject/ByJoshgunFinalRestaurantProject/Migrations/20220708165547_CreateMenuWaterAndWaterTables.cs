using Microsoft.EntityFrameworkCore.Migrations;

namespace ByJoshgunFinalRestaurantProject.Migrations
{
    public partial class CreateMenuWaterAndWaterTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MenuWaters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuWaters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Waters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    MenuWaterId = table.Column<int>(type: "int", nullable: false),
                    IsDeactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Waters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Waters_MenuWaters_MenuWaterId",
                        column: x => x.MenuWaterId,
                        principalTable: "MenuWaters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Waters_MenuWaterId",
                table: "Waters",
                column: "MenuWaterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Waters");

            migrationBuilder.DropTable(
                name: "MenuWaters");
        }
    }
}
