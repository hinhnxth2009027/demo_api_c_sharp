using System.Collections.Generic;

namespace API_C_Sharp
{
    public class Coin
    {
        public string Symbol { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Bid { get; set; }
        public double BidSize { get; set; }

        public override string ToString()
        {
            return $"Symbol : {Symbol} \t High : {High} \t Low : {Low} \t Bid : {Bid} \t BidSize {BidSize}";
        }
    }
}