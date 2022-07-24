using Coins_New.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using library;


namespace Coins_New.Controllers
{
    public class HomeController : Controller
    {
               
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }         

        public IActionResult Index()
        {

            using (CoinContext db = new CoinContext())
            {

                //// Створюємо декілька об'єктів Coin
                //Coin Coin1 = new Coin { Id = Guid.NewGuid(), Year = 1992, Category = "Circulating coins", Country = "Ukraine", Value = 3, Currency = "uah" };
                //Coin Coin2 = new Coin { Id = Guid.NewGuid(), Year = 2000, Category = "Circulating coins", Country = "Poland", Value = 2, Currency = "zŁ" };
                //Coin Coin3 = new Coin { Id = Guid.NewGuid(), Year = 2022, Category = "Commemorative coins", Country = "Norway", Value = 4, Currency = "krone" };
                //Coin Coin4 = new Coin { Id = Guid.NewGuid(), Year = 1852, Category = "Commemorative coins", Country = "United Kingdom", Value = 1, Currency = "penny" };
                //Coin Coin5 = new Coin { Id = Guid.NewGuid(), Year = 1775, Category = "Collectable coins", Country = "Italy", Value = 5, Currency = "cent" };

                //// Створюємо декілька об'єктів Category
                //Category cat1 = new Category { Id = Guid.NewGuid(), CategoryName = "Circulating coins" };
                //Category cat2 = new Category { Id = Guid.NewGuid(), CategoryName = "Commemorative coins" };
                //Category cat3 = new Category { Id = Guid.NewGuid(), CategoryName = "Collectable coins" };

                ////// Створюємо декілька об'єктів Country
                //Country Country1 = new Country { Id = Guid.NewGuid(), CountryName = "Ukraine" };
                //Country Country2 = new Country { Id = Guid.NewGuid(), CountryName = "Poland" };
                //Country Country3 = new Country { Id = Guid.NewGuid(), CountryName = "Norway" };
                //Country Country4 = new Country { Id = Guid.NewGuid(), CountryName = "United Kingdom" };
                //Country Country5 = new Country { Id = Guid.NewGuid(), CountryName = "Italy" };


                ////// Створюємо декілька об'єктів Value
                //Value Value1 = new Value { Id = Guid.NewGuid(), ValueName = 1 };
                //Value Value2 = new Value { Id = Guid.NewGuid(), ValueName = 2 };
                //Value Value3 = new Value { Id = Guid.NewGuid(), ValueName = 3 };
                //Value Value4 = new Value { Id = Guid.NewGuid(), ValueName = 5 };
                //Value Value5 = new Value { Id = Guid.NewGuid(), ValueName = 10 };

                ////// Створюємо декілька об'єктів Currency
                //Currency Currency1 = new Currency { Id = Guid.NewGuid(), CurrencyName = "uah", CountryName = "Ukraine" };
                //Currency Currency2 = new Currency { Id = Guid.NewGuid(), CurrencyName = "zŁ", CountryName = "Poland" };
                //Currency Currency3 = new Currency { Id = Guid.NewGuid(), CurrencyName = "krone", CountryName = "Norway" };
                //Currency Currency4 = new Currency { Id = Guid.NewGuid(), CurrencyName = "penny", CountryName = "United Kingdom" };
                //Currency Currency5 = new Currency { Id = Guid.NewGuid(), CurrencyName = "cent", CountryName = "Italy" };

                ////// Створюємо декілька об'єктів Year
                //Year Year1 = new Year { Id = Guid.NewGuid(), YearName = 1775 };
                //Year Year2 = new Year { Id = Guid.NewGuid(), YearName = 1992 };
                //Year Year3 = new Year { Id = Guid.NewGuid(), YearName = 2000 };
                //Year Year4 = new Year { Id = Guid.NewGuid(), YearName = 1852 };
                //Year Year5 = new Year { Id = Guid.NewGuid(), YearName = 2022 };


                //// Додаємо їх до бд
                //db.Coins.Add(Coin1);
                //db.Coins.Add(Coin2);
                //db.Coins.Add(Coin3);
                //db.Coins.Add(Coin4);
                //db.Coins.Add(Coin5);


                ////// Categories
                //db.Categories.Add(cat1);
                //db.Categories.Add(cat2);
                //db.Categories.Add(cat3);

                ////// Countries
                //db.Countries.Add(Country1);
                //db.Countries.Add(Country2);
                //db.Countries.Add(Country3);
                //db.Countries.Add(Country4);
                //db.Countries.Add(Country5);

                //////Values
                //db.ValuesCoins.Add(Value1);
                //db.ValuesCoins.Add(Value2);
                //db.ValuesCoins.Add(Value3);
                //db.ValuesCoins.Add(Value4);
                //db.ValuesCoins.Add(Value5);

                //////Currencies
                //db.Currencies.Add(Currency1);
                //db.Currencies.Add(Currency2);
                //db.Currencies.Add(Currency3);
                //db.Currencies.Add(Currency4);
                //db.Currencies.Add(Currency5);

                //////Year
                //db.Years.Add(Year1);
                //db.Years.Add(Year2);
                //db.Years.Add(Year3);
                //db.Years.Add(Year4);
                //db.Years.Add(Year5);

                //db.SaveChanges();



                List<Coin> coins = db.Coins.ToList();
                List<Country> countries = db.Countries.ToList();
                List<Currency> currencies = db.Currencies.ToList();
                List<Category> categories = db.Categories.ToList();
                List<Year> years = db.Years.ToList();
                List<Value> values = db.ValuesCoins.ToList();
                AllModel allModel = new AllModel { 
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
            //return View();

        }

        public IActionResult Privacy()
        {
            return View();
        }      

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }        

    }

    
}
