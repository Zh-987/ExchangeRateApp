using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrackingCzechExchangeRates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CurrencyValuesJson",
                table: "CurrencyDataSet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrencyValuesJson",
                table: "CurrencyDataSet");
        }
    }
}
