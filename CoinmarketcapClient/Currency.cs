using System;
using Newtonsoft.Json;

namespace NoobsMuc.Coinmarketcap.Client
{
    public class Currency
    {
        public int Id { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public int Rank { get; set; }
        public decimal Price { get; set; }
        public decimal Volume24hUsd { get; set; }
        public decimal MarketCapUsd { get; set; }
        public decimal PercentChange1h { get; set; }
        public decimal PercentChange24h { get; set; }
        public decimal PercentChange7d { get; set; }
        public DateTime LastUpdated { get; set; }
        public decimal MarketCapConvert { get; set; }
        public string ConvertCurrency { get; set; }
    }
}