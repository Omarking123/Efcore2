using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Efcore2.Migrations
{
    /// <inheritdoc />
    public partial class addonetoManyrelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WorkForId",
                table: "Employee",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_WorkForId",
                table: "Employee",
                column: "WorkForId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Department_WorkForId",
                table: "Employee",
                column: "WorkForId",
                principalTable: "Department",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Department_WorkForId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_WorkForId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "WorkForId",
                table: "Employee");
        }
    }
}
