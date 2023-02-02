using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockManagement.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddItemCase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookCaseId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemCaseId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ItemCase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCase", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemCaseId",
                table: "Items",
                column: "ItemCaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemCase_ItemCaseId",
                table: "Items",
                column: "ItemCaseId",
                principalTable: "ItemCase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemCase_ItemCaseId",
                table: "Items");

            migrationBuilder.DropTable(
                name: "ItemCase");

            migrationBuilder.DropIndex(
                name: "IX_Items_ItemCaseId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "BookCaseId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ItemCaseId",
                table: "Items");
        }
    }
}
