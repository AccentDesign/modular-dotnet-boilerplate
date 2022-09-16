using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Modules.EmployeeManagement.Infrastructure.Migrations
{
    public partial class inittables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "StaffManagement");

            migrationBuilder.CreateTable(
                name: "Staves",
                schema: "StaffManagement",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Family = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StaffTask",
                schema: "StaffManagement",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StaffId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Due = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffTask", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaffTask_Staves_StaffId",
                        column: x => x.StaffId,
                        principalSchema: "StaffManagement",
                        principalTable: "Staves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StaffTask_StaffId",
                schema: "StaffManagement",
                table: "StaffTask",
                column: "StaffId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StaffTask",
                schema: "StaffManagement");

            migrationBuilder.DropTable(
                name: "Staves",
                schema: "StaffManagement");
        }
    }
}
