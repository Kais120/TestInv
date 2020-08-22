using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Test.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Uid = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    RegDate = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Uid);
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    Uid = table.Column<Guid>(nullable: false),
                    CompanyUid = table.Column<Guid>(nullable: false),
                    Number = table.Column<string>(nullable: true),
                    InvDate = table.Column<DateTime>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Total = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.Uid);
                    table.ForeignKey(
                        name: "FK_Invoice_Company_CompanyUid",
                        column: x => x.CompanyUid,
                        principalTable: "Company",
                        principalColumn: "Uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_CompanyUid",
                table: "Invoice",
                column: "CompanyUid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
