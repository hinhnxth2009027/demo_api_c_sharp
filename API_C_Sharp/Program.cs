using System;
using API_C_Sharp.HiTrader;

namespace API_C_Sharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            BitfinexTrader bitfinexTrader = new BitfinexTrader();
            HuobiTrader huobiTrader = new HuobiTrader();

            foreach (var item in bitfinexTrader.GetTickers())
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}