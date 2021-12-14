using Microsoft.EntityFrameworkCore.Migrations;

namespace TreeStructure.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NodeElements",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    parentId = table.Column<int>(type: "int", nullable: true),
                    NodeElementid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NodeElements", x => x.id);
                    table.ForeignKey(
                        name: "FK_NodeElements_NodeElements_NodeElementid",
                        column: x => x.NodeElementid,
                        principalTable: "NodeElements",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NodeElements_NodeElementid",
                table: "NodeElements",
                column: "NodeElementid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NodeElements");
        }
    }
}
