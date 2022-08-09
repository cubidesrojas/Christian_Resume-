using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Christian_Resume_Web_API.Migrations
{
    public partial class clients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client_Messages",
                columns: table => new
                {
                    Client_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CLient_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Client_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Client_PhoneNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client_Messages", x => x.Client_Id);
                });

            migrationBuilder.CreateTable(
                name: "projects",
                columns: table => new
                {
                    Project_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Project_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Project_url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projects", x => x.Project_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client_Messages");

            migrationBuilder.DropTable(
                name: "projects");
        }
    }
}
