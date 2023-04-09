using Microsoft.EntityFrameworkCore.Migrations;

namespace RobotnaFinalPro.Migrations
{
    public partial class dha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "instructors",
                columns: table => new
                {
                    InstructorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstructorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FbUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstructorImg = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instructors", x => x.InstructorId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "instructors");
        }
    }
}
