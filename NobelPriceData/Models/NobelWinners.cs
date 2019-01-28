using System;
using System.Collections.Generic;

namespace NobelPriceData.Models
{
    public partial class NobelWinners
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Born { get; set; }
        public DateTime? Died { get; set; }
        public string BornCountry { get; set; }
        public string BornCountryCode { get; set; }
        public string BornCity { get; set; }
        public string DiedCountry { get; set; }
        public string DiedCountryCode { get; set; }
        public string DiedCity { get; set; }
        public string Gender { get; set; }

        public NobelPrizes IdNavigation { get; set; }
    }
}
