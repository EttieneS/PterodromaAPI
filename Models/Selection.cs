using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASGExchangeAPI
{
    public class Selection
    {
        public long Id { get; set; }
        public long[]? Currency { get; set; }
    }
}
