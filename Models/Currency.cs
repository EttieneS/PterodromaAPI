using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASGExchangeAPI.Models
{
    public class Currency
    {
        public long Id { get; set; }
        public string? CurrencyName { get; set; }
        public string? CurrencyCode { get; set; }
    }
}
