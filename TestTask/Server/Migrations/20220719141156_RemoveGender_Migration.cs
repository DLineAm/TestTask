using Microsoft.EntityFrameworkCore.Migrations;

namespace TestTask.Server.Migrations
{
    public partial class RemoveGender_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Gender_GenderId",
                table: "Employee");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropIndex(
                name: "IX_Employee_GenderId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "Employee");

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Employee");

            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_GenderId",
                table: "Employee",
                column: "GenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Gender_GenderId",
                table: "Employee",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "Id");
        }
    }
}
