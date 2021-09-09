using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DocPatientPortal.Migrations
{
    public partial class Initial_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "appointment",
                columns: table => new
                {
                    aid = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    uid = table.Column<int>(nullable: false),
                    doc_id = table.Column<int>(nullable: false),
                    adate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appointment", x => x.aid);
                });

            migrationBuilder.CreateTable(
                name: "doctor_details",
                columns: table => new
                {
                    d_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    d_full_name = table.Column<string>(nullable: true),
                    d_dob = table.Column<DateTime>(nullable: false),
                    d_contact = table.Column<string>(nullable: true),
                    d_email = table.Column<string>(nullable: true),
                    d_certificate = table.Column<string>(nullable: true),
                    d_state = table.Column<string>(nullable: true),
                    d_city = table.Column<string>(nullable: true),
                    d_full_address = table.Column<string>(nullable: true),
                    d_gender = table.Column<string>(nullable: true),
                    d_blood_group = table.Column<string>(nullable: true),
                    d_speciality = table.Column<string>(nullable: true),
                    d_username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doctor_details", x => x.d_id);
                });

            migrationBuilder.CreateTable(
                name: "patient_details",
                columns: table => new
                {
                    p_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    p_fullname = table.Column<string>(nullable: true),
                    p_dob = table.Column<DateTime>(nullable: false),
                    p_contact = table.Column<string>(nullable: true),
                    p_email = table.Column<string>(nullable: true),
                    p_photo = table.Column<string>(nullable: true),
                    p_state = table.Column<string>(nullable: true),
                    p_city = table.Column<string>(nullable: true),
                    p_gender = table.Column<string>(nullable: true),
                    p_fulladdress = table.Column<string>(nullable: true),
                    p_blood = table.Column<string>(nullable: true),
                    p_username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patient_details", x => x.p_id);
                });

            migrationBuilder.CreateTable(
                name: "prescription",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    p_id = table.Column<int>(nullable: false),
                    information = table.Column<string>(nullable: true),
                    medication = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prescription", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "unavailability",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    did = table.Column<int>(nullable: false),
                    absent_date = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_unavailability", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    pid = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    pname = table.Column<string>(nullable: true),
                    paddress = table.Column<string>(nullable: true),
                    pblood = table.Column<string>(nullable: true),
                    pnumber = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.pid);
                });

            migrationBuilder.CreateTable(
                name: "userlogin",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    username = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: false),
                    role = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userlogin", x => x.uid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "appointment");

            migrationBuilder.DropTable(
                name: "doctor_details");

            migrationBuilder.DropTable(
                name: "patient_details");

            migrationBuilder.DropTable(
                name: "prescription");

            migrationBuilder.DropTable(
                name: "unavailability");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "userlogin");
        }
    }
}
