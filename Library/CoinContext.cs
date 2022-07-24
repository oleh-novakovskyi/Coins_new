
using System;
using System.Data.Entity;
using System.Web;

namespace library
{
    public class CoinContext : DbContext
    {

        public CoinContext()
        : base("coinsNew")
        { }
        public DbSet<Coin> Coins { get; set; }
        public DbSet<Year> Years { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Value> ValuesCoins { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Category> Categories { get; set; }       

        
    }

    public class Coin
    {
        public Guid Id { get; set; }
        public string Category { get; set; }
        public string Country { get; set; }
        public int Year { get; set; }
        public int Value { get; set; }
        public string Currency { get; set; }
    }
    public class Category
    {
        public Guid Id { get; set; }
        public string CategoryName { get; set; }
    }
    public class Country
    {
        public Guid Id { get; set; }
        public string CountryName { get; set; }
    }

    public class Value
    {
        public Guid Id { get; set; }
        public int ValueName { get; set; }
    }

    public class Currency
    {
        public Guid Id { get; set; }
        public string CurrencyName { get; set; }
        public string CountryName { get; set; }
    }

    public class Year
    {
        public Guid Id { get; set; }
        public int YearName { get; set; }
    }
}
