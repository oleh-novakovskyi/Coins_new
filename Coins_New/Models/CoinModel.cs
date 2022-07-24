using System;
namespace Coins_New.Models
{
    public class CoinModel
    {
        public Guid Id { get; set; }
        public string Category { get; set; }
        public string Country { get; set; }
        public int Year { get; set; }
        public int Value { get; set; }
        public string Currency { get; set; }
    }
}
