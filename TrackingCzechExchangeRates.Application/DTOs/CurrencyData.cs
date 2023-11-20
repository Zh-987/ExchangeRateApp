using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingCzechExchangeRates.Application.DTOs
{
    public class CurrencyData
    {
        public DateTime Date { get; set; }
        
        public Dictionary<string, decimal> CurrencyValues { get; set; }
       
        public CurrencyData()
        {   
            CurrencyValues = new Dictionary<string, decimal>();
        }

    }
}
