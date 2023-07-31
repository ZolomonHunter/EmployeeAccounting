using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeAccounting.Migrations
{
    /// <inheritdoc />
    public partial class fixedHeadDivision2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_division_employee_manager_id",
                table: "division");

            migrationBuilder.DropForeignKey(
                name: "FK_employee_division_division_id",
                table: "employee");

            migrationBuilder.RenameColumn(
                name: "division_id",
                table: "employee",
                newName: "DivisionId");

            migrationBuilder.RenameIndex(
                name: "IX_employee_division_id",
                table: "employee",
                newName: "IX_employee_DivisionId");

            migrationBuilder.RenameColumn(
                name: "manager_id",
                table: "division",
                newName: "ManagerId");

            migrationBuilder.RenameIndex(
                name: "IX_division_manager_id",
                table: "division",
                newName: "IX_division_ManagerId");

            migrationBuilder.AlterColumn<int>(
                name: "ManagerId",
                table: "division",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_division_employee_ManagerId",
                table: "division",
                column: "ManagerId",
                principalTable: "employee",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_employee_division_DivisionId",
                table: "employee",
                column: "DivisionId",
                principalTable: "division",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_division_employee_ManagerId",
                table: "division");

            migrationBuilder.DropForeignKey(
                name: "FK_employee_division_DivisionId",
                table: "employee");

            migrationBuilder.RenameColumn(
                name: "DivisionId",
                table: "employee",
                newName: "division_id");

            migrationBuilder.RenameIndex(
                name: "IX_employee_DivisionId",
                table: "employee",
                newName: "IX_employee_division_id");

            migrationBuilder.RenameColumn(
                name: "ManagerId",
                table: "division",
                newName: "manager_id");

            migrationBuilder.RenameIndex(
                name: "IX_division_ManagerId",
                table: "division",
                newName: "IX_division_manager_id");

            migrationBuilder.AlterColumn<int>(
                name: "manager_id",
                table: "division",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_division_employee_manager_id",
                table: "division",
                column: "manager_id",
                principalTable: "employee",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_employee_division_division_id",
                table: "employee",
                column: "division_id",
                principalTable: "division",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
