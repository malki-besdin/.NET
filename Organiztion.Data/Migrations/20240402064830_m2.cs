using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Organization.Data.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RolesToEmployee_Employees_EmployeeId",
                table: "RolesToEmployee");

            migrationBuilder.DropIndex(
                name: "IX_RolesToEmployee_EmployeeId",
                table: "RolesToEmployee");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "RolesToEmployee");

            migrationBuilder.RenameColumn(
                name: "IdRole",
                table: "RolesToEmployee",
                newName: "IdRoleId");

            migrationBuilder.RenameColumn(
                name: "IdEmployee",
                table: "RolesToEmployee",
                newName: "IdEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_RolesToEmployee_IdEmployeeId",
                table: "RolesToEmployee",
                column: "IdEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_RolesToEmployee_IdRoleId",
                table: "RolesToEmployee",
                column: "IdRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_RolesToEmployee_Employees_IdEmployeeId",
                table: "RolesToEmployee",
                column: "IdEmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RolesToEmployee_Roles_IdRoleId",
                table: "RolesToEmployee",
                column: "IdRoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RolesToEmployee_Employees_IdEmployeeId",
                table: "RolesToEmployee");

            migrationBuilder.DropForeignKey(
                name: "FK_RolesToEmployee_Roles_IdRoleId",
                table: "RolesToEmployee");

            migrationBuilder.DropIndex(
                name: "IX_RolesToEmployee_IdEmployeeId",
                table: "RolesToEmployee");

            migrationBuilder.DropIndex(
                name: "IX_RolesToEmployee_IdRoleId",
                table: "RolesToEmployee");

            migrationBuilder.RenameColumn(
                name: "IdRoleId",
                table: "RolesToEmployee",
                newName: "IdRole");

            migrationBuilder.RenameColumn(
                name: "IdEmployeeId",
                table: "RolesToEmployee",
                newName: "IdEmployee");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "RolesToEmployee",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RolesToEmployee_EmployeeId",
                table: "RolesToEmployee",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_RolesToEmployee_Employees_EmployeeId",
                table: "RolesToEmployee",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");
        }
    }
}
