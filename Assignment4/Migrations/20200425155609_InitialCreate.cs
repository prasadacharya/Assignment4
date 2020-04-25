using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment4.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    status = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.status);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    status = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.status);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    status = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.status);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    sequence = table.Column<int>(nullable: false),
                    Categoriesstatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.id);
                    table.ForeignKey(
                        name: "FK_Category_Categories_Categoriesstatus",
                        column: x => x.Categoriesstatus,
                        principalTable: "Categories",
                        principalColumn: "status",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Report",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    desc = table.Column<string>(nullable: true),
                    Reportsstatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report", x => x.id);
                    table.ForeignKey(
                        name: "FK_Report_Reports_Reportsstatus",
                        column: x => x.Reportsstatus,
                        principalTable: "Reports",
                        principalColumn: "status",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    code = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    Statesstatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.id);
                    table.ForeignKey(
                        name: "FK_State_States_Statesstatus",
                        column: x => x.Statesstatus,
                        principalTable: "States",
                        principalColumn: "status",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Category_Categoriesstatus",
                table: "Category",
                column: "Categoriesstatus");

            migrationBuilder.CreateIndex(
                name: "IX_Report_Reportsstatus",
                table: "Report",
                column: "Reportsstatus");

            migrationBuilder.CreateIndex(
                name: "IX_State_Statesstatus",
                table: "State",
                column: "Statesstatus");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Report");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "States");
        }
    }
}
