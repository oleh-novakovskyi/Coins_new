using Coins_New.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using library;
using System.Dynamic;

namespace Coins_New.Controllers
{
    public class CoinController : Controller
    {
        public IActionResult Index()
        {
            
         return View();        
           
        }

        public IActionResult Add()
        {
            using (CoinContext db = new CoinContext())
            {
                List<Coin> coins = db.Coins.ToList();
                List<Country> countries = db.Countries.ToList();
                List<Currency> currencies = db.Currencies.ToList();
                List<Category> categories = db.Categories.ToList();
                List<Year> years = db.Years.ToList();
                List<Value> values = db.ValuesCoins.ToList();
                AllModel allModel = new AllModel
                {
                    Coins = coins,
                    Countries = countries,
                    Currencies = currencies,
                    Years = years,
                    Values = values,
                    Categories = categories
                };
                var allDb = allModel;

                return View(allDb);
            }
            
        }
    }
}
