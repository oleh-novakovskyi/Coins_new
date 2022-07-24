
using System;
using System.Collections.Generic;
using System.Data.Entity;
using library;
namespace Coins_New.Models
{
    public class AllModel
    {
        public List<Coin> Coins { get; set; }
        public List<Country> Countries { get; set; }
        public List<Currency> Currencies { get; set; }
        public List<Value> Values { get; set; }
        public List<Year> Years { get; set; }
        public List<Category> Categories { get; set; }
    }
}
