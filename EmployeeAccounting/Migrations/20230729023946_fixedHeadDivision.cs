using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeAccounting.Migrations
{
    /// <inheritdoc />
    public partial class fixedHeadDivision : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_division_division_head_division_id",
                table: "division");

            migrationBuilder.RenameColumn(
                name: "head_division_id",
                table: "division",
                newName: "HeadDivisionId");

            migrationBuilder.RenameIndex(
                name: "IX_division_head_division_id",
                table: "division",
                newName: "IX_division_HeadDivisionId");

            migrationBuilder.AlterColumn<int>(
                name: "HeadDivisionId",
                table: "division",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_division_division_HeadDivisionId",
                table: "division",
                column: "HeadDivisionId",
                principalTable: "division",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_division_division_HeadDivisionId",
                table: "division");

            migrationBuilder.RenameColumn(
                name: "HeadDivisionId",
                table: "division",
                newName: "head_division_id");

            migrationBuilder.RenameIndex(
                name: "IX_division_HeadDivisionId",
                table: "division",
                newName: "IX_division_head_division_id");

            migrationBuilder.AlterColumn<int>(
                name: "head_division_id",
                table: "division",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_division_division_head_division_id",
                table: "division",
                column: "head_division_id",
                principalTable: "division",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
