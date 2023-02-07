using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockManagement.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class NullableItemCaseId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemCases_ItemCaseId",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "ItemCaseId",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemCases_ItemCaseId",
                table: "Items",
                column: "ItemCaseId",
                principalTable: "ItemCases",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemCases_ItemCaseId",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "ItemCaseId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemCases_ItemCaseId",
                table: "Items",
                column: "ItemCaseId",
                principalTable: "ItemCases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
