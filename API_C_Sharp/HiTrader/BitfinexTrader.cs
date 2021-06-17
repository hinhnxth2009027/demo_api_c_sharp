using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace API_C_Sharp.HiTrader
{
    public class BitfinexTrader : ITraderAction
    {
        public List<Coin> GetTickers()
        {
            var coins = new List<Coin>();
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml+json");
            var url = "https://api-pub.bitfinex.com/v2/tickers?symbols=ALL";
            Task<string> response = httpClient.GetStringAsync(url);
            var data = JArray.Parse(response.Result);
            foreach (var item in data)
            {
                coins.Add(new Coin
                {
                    Symbol = item[0].Value<string>(),
                    High = item[9].Value<double>(),
                    Low = item[10].Value<double>(),
                    Bid = item[2].Value<double>(),
                    BidSize = item[4].Value<double>()
                });
            }

            return coins;
        }
    }
}