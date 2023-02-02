using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockManagement.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Suppliers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemCase_ItemCaseId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemCase",
                table: "ItemCase");

            migrationBuilder.RenameTable(
                name: "ItemCase",
                newName: "ItemCases");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemCases",
                table: "ItemCases",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemSupplier",
                columns: table => new
                {
                    ItemsId = table.Column<int>(type: "int", nullable: false),
                    SuppliersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemSupplier", x => new { x.ItemsId, x.SuppliersId });
                    table.ForeignKey(
                        name: "FK_ItemSupplier_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemSupplier_Suppliers_SuppliersId",
                        column: x => x.SuppliersId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemSupplier_SuppliersId",
                table: "ItemSupplier",
                column: "SuppliersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemCases_ItemCaseId",
                table: "Items",
                column: "ItemCaseId",
                principalTable: "ItemCases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemCases_ItemCaseId",
                table: "Items");

            migrationBuilder.DropTable(
                name: "ItemSupplier");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemCases",
                table: "ItemCases");

            migrationBuilder.RenameTable(
                name: "ItemCases",
                newName: "ItemCase");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemCase",
                table: "ItemCase",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemCase_ItemCaseId",
                table: "Items",
                column: "ItemCaseId",
                principalTable: "ItemCase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
