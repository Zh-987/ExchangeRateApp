﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrackingCzechExchangeRates.Infrastructure;

#nullable disable

namespace TrackingCzechExchangeRates.Infrastructure.Migrations
{
    [DbContext(typeof(CurrencyDBContext))]
    [Migration("20231119212113_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TrackingCzechExchangeRates.Core.DTOs.CurrencyData", b =>
                {
                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("AUD")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("BGN")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("BRL")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CAD")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CHF")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CNY")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("DKK")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("EUR")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GBP")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("HKD")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("HRK")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("HUF")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("IDR")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ILS")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("INR")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ISK")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("JPY")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("KRW")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MXN")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MYR")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NOK")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NZD")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PHP")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PLN")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RON")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RUB")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SEK")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SGD")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("THB")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TRY")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("USD")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("XDR")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ZAR")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Date");

                    b.ToTable("CurrencyDataSet");
                });
#pragma warning restore 612, 618
        }
    }
}
