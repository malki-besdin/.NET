using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Organization.Data.Migrations
{
    public partial class m3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RolesToEmployee_Employees_IdEmployeeId",
                table: "RolesToEmployee");

            migrationBuilder.RenameColumn(
                name: "IdEmployeeId",
                table: "RolesToEmployee",
                newName: "employeeId");

            migrationBuilder.RenameIndex(
                name: "IX_RolesToEmployee_IdEmployeeId",
                table: "RolesToEmployee",
                newName: "IX_RolesToEmployee_employeeId");

            migrationBuilder.AddColumn<string>(
                name: "IdEmployee",
                table: "RolesToEmployee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_RolesToEmployee_Employees_employeeId",
                table: "RolesToEmployee",
                column: "employeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RolesToEmployee_Employees_employeeId",
                table: "RolesToEmployee");

            migrationBuilder.DropColumn(
                name: "IdEmployee",
                table: "RolesToEmployee");

            migrationBuilder.RenameColumn(
                name: "employeeId",
                table: "RolesToEmployee",
                newName: "IdEmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_RolesToEmployee_employeeId",
                table: "RolesToEmployee",
                newName: "IX_RolesToEmployee_IdEmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_RolesToEmployee_Employees_IdEmployeeId",
                table: "RolesToEmployee",
                column: "IdEmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
