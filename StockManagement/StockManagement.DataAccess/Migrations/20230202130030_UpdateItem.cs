using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockManagement.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookCaseId",
                table: "Items");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookCaseId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
