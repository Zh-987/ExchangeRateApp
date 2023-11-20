using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrackingCzechExchangeRates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AUD",
                table: "CurrencyDataSet");

            migrationBuilder.DropColumn(
                name: "BGN",
                table: "CurrencyDataSet");

            migrationBuilder.DropColumn(
                name: "BRL",
                table: "CurrencyDataSet");

            migrationBuilder.DropColumn(
                name: "CAD",
                table: "CurrencyDataSet");

            migrationBuilder.DropColumn(
                name: "CHF",
                table: "CurrencyDataSet");

            migrationBuilder.DropColumn(
                name: "CNY",
                table: "CurrencyDataSet");

            migrationBuilder.DropColumn(
                name: "DKK",
                table: "CurrencyDataSet");

            migrationBuilder.DropColumn(
                name: "EUR",
                table: "CurrencyDataSet");

            migrationBuilder.DropColumn(
                name: "GBP",
                table: "CurrencyDataSet");

            migrationBuilder.DropColumn(
                name: "HKD",
                table: "CurrencyDataSet");

            migrationBuilder.DropColumn(
                name: "HRK",
                table: "CurrencyDataSet");

            migrationBuilder.DropColumn(
                name: "HUF",
                table: "CurrencyDataSet");

            migrationBuilder.DropColumn(
                name: "IDR",
                table: "CurrencyDataSet");

            migrationBuilder.DropColumn(
                name: "ILS",
                table: "CurrencyDataSet");

            migrationBuilder.DropColumn(
                name: "INR",
                table: "CurrencyDataSet");

            migrationBuilder.DropColumn(
                name: "ISK",
                table: "CurrencyDataSet");

            migrationBuilder.DropColumn(
                name: "JPY",
                table: "CurrencyDataSet");

            migrationBuilder.DropColumn(
                name: "KRW",
                table: "CurrencyDataSet");

            migrationBuilder.DropColumn(
                name: "MXN",
                table: "CurrencyDataSet");

            migrationBuilder.DropColumn(
                name: "MYR",
                table: "CurrencyDataSet");

            migrationBuilder.DropColumn(
                name: "NOK",
                table: "CurrencyDataSet");

            migrationBuilder.DropColumn(
                name: "NZD",
                table: "CurrencyDataSet");

            migrationBuilder.DropColumn(
                name: "PHP",
                table: "CurrencyDataSet");

            migrationBuilder.DropColumn(
                name: "PLN",
                table: "CurrencyDataSet");

            migrationBuilder.DropColumn(
                name: "RON",
                table: "CurrencyDataSet");

            migrationBuilder.DropColumn(
                name: "RUB",
                table: "CurrencyDataSet");

            migrationBuilder.DropColumn(
                name: "SEK",
                table: "CurrencyDataSet");

            migrationBuilder.DropColumn(
                name: "SGD",
                table: "CurrencyDataSet");

            migrationBuilder.DropColumn(
                name: "THB",
                table: "CurrencyDataSet");

            migrationBuilder.DropColumn(
                name: "TRY",
                table: "CurrencyDataSet");

            migrationBuilder.DropColumn(
                name: "USD",
                table: "CurrencyDataSet");

            migrationBuilder.DropColumn(
                name: "XDR",
                table: "CurrencyDataSet");

            migrationBuilder.DropColumn(
                name: "ZAR",
                table: "CurrencyDataSet");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AUD",
                table: "CurrencyDataSet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "BGN",
                table: "CurrencyDataSet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "BRL",
                table: "CurrencyDataSet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CAD",
                table: "CurrencyDataSet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CHF",
                table: "CurrencyDataSet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CNY",
                table: "CurrencyDataSet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DKK",
                table: "CurrencyDataSet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "EUR",
                table: "CurrencyDataSet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "GBP",
                table: "CurrencyDataSet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "HKD",
                table: "CurrencyDataSet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "HRK",
                table: "CurrencyDataSet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "HUF",
                table: "CurrencyDataSet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "IDR",
                table: "CurrencyDataSet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ILS",
                table: "CurrencyDataSet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "INR",
                table: "CurrencyDataSet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ISK",
                table: "CurrencyDataSet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "JPY",
                table: "CurrencyDataSet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "KRW",
                table: "CurrencyDataSet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MXN",
                table: "CurrencyDataSet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MYR",
                table: "CurrencyDataSet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "NOK",
                table: "CurrencyDataSet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "NZD",
                table: "CurrencyDataSet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PHP",
                table: "CurrencyDataSet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PLN",
                table: "CurrencyDataSet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "RON",
                table: "CurrencyDataSet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "RUB",
                table: "CurrencyDataSet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SEK",
                table: "CurrencyDataSet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SGD",
                table: "CurrencyDataSet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "THB",
                table: "CurrencyDataSet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TRY",
                table: "CurrencyDataSet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "USD",
                table: "CurrencyDataSet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "XDR",
                table: "CurrencyDataSet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ZAR",
                table: "CurrencyDataSet",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
