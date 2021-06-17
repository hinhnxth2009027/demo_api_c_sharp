using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace API_C_Sharp.HiTrader
{
    public class HuobiTrader:ITraderAction
    {
        public List<Coin> GetTickers()
        {
            var coins = new List<Coin>();
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml+json");
            var url = "https://api.huobi.pro/market/tickers";
            Task<string> response = httpClient.GetStringAsync(url);
            var data = JObject.Parse(response.Result);
            foreach (var item in data["data"])
            {
                coins.Add(new Coin
                {
                    Symbol = item["symbol"].Value<string>(),
                    High = item["high"].Value<double>(),
                    Low = item["low"].Value<double>(),
                    Bid = item["bid"].Value<double>(),
                    BidSize = item["bidSize"].Value<double>()
                });
            }
            return coins;
        }
    }
}