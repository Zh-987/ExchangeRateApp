


using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingCzechExchangeRates.Core.DTOs;

namespace TrackingCzechExchangeRates.Infrastructure.Repositories
{
    public class CurrencyDataRepository
    {
        private readonly CurrencyDBContext _dbContext;

        public CurrencyDataRepository(CurrencyDBContext dbContext)
        {
            _dbContext = dbContext;
        }

    }
}