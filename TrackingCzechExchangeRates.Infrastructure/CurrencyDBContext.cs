using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TrackingCzechExchangeRates.Core.DTOs;

namespace TrackingCzechExchangeRates.Infrastructure
{
    public class CurrencyDBContext : DbContext
    {

        public DbSet<CurrencyData> CurrencyDataSet { get; set; }

        public CurrencyDBContext(DbContextOptions<CurrencyDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the CurrencyData entity as needed
            modelBuilder.Entity<CurrencyData>().HasKey(c => c.Date);
            modelBuilder.Entity<CurrencyData>().HasKey(c => c.CurrencyValues);
            // Add any other configurations

            base.OnModelCreating(modelBuilder);
        }
    }
}
