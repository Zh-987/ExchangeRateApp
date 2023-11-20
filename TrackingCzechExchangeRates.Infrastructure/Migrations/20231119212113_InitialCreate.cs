using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrackingCzechExchangeRates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CurrencyDataSet",
                columns: table => new
                {
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AUD = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BGN = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BRL = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CAD = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CHF = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CNY = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DKK = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EUR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GBP = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HKD = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HRK = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HUF = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IDR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ILS = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    INR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ISK = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JPY = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KRW = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MXN = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MYR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NOK = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NZD = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PHP = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PLN = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RON = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RUB = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SEK = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SGD = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    THB = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TRY = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    USD = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    XDR = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ZAR = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencyDataSet", x => x.Date);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurrencyDataSet");
        }
    }
}
