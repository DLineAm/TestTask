using Microsoft.EntityFrameworkCore.Migrations;

namespace TestTask.Server.Migrations
{
    public partial class RemovedEmployeeCascadeDelete_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Division_DivisionId",
                table: "Employee");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Division_DivisionId",
                table: "Employee",
                column: "DivisionId",
                principalTable: "Division",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Division_DivisionId",
                table: "Employee");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Division_DivisionId",
                table: "Employee",
                column: "DivisionId",
                principalTable: "Division",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
