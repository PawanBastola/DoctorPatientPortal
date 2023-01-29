using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DocPatientPortal.Migrations
{
    public partial class recreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "appointment",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "feedbacks",
                columns: table => new
                {
                    fid = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    fullname = table.Column<string>(nullable: true),
                    role = table.Column<string>(nullable: true),
                    message = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_feedbacks", x => x.fid);
                });

            migrationBuilder.CreateTable(
                name: "organdetails",
                columns: table => new
                {
                    org_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    donername = table.Column<string>(nullable: true),
                    organ = table.Column<string>(nullable: true),
                    bloodgroup = table.Column<string>(nullable: true),
                    mobilenumber = table.Column<long>(nullable: false),
                    status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_organdetails", x => x.org_id);
                });

            migrationBuilder.CreateTable(
                name: "speciality",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    spec = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_speciality", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "feedbacks");

            migrationBuilder.DropTable(
                name: "organdetails");

            migrationBuilder.DropTable(
                name: "speciality");

            migrationBuilder.DropColumn(
                name: "status",
                table: "appointment");
        }
    }
}
