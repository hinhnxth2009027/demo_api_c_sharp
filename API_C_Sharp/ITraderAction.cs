using System.Collections.Generic;

namespace API_C_Sharp
{
    public interface ITraderAction
    {
        List<Coin> GetTickers();
    }
}