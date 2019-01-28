using System;
using System.Collections.Generic;

namespace NobelPriceData.Models
{
    public partial class NobelPrizes
    {
        public int Id { get; set; }
        public double? Year { get; set; }
        public string Category { get; set; }
        public double? Share { get; set; }
        public string Motivation { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public NobelWinners NobelWinners { get; set; }
    }
}
