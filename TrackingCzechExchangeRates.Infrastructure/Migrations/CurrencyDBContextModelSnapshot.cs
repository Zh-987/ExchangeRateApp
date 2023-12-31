﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrackingCzechExchangeRates.Infrastructure;

#nullable disable

namespace TrackingCzechExchangeRates.Infrastructure.Migrations
{
    [DbContext(typeof(CurrencyDBContext))]
    partial class CurrencyDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("CurrencyValuesJson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Date");

                    b.ToTable("CurrencyDataSet");
                });
#pragma warning restore 612, 618
        }
    }
}
