using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesforceCore.Migrations
{
    public partial class AddedAnualPackagingSpendFieldToAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "AnnualPackagingSpend",
                table: "Accounts",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnnualPackagingSpend",
                table: "Accounts");
        }
    }
}
