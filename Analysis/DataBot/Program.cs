using DataBot.Utils;
using Persistence.Domain.Implement;
using Persistence.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// https://docs.microsoft.com/ko-kr/dotnet/csharp/tutorials/console-webapiclient

namespace DataBot
{
    class Program
    {
        //https://docs.microsoft.com/ko-kr/dotnet/csharp/programming-guide/concepts/async/

        static async Task Main(string[] args)
        {
            string result = await Http.GetStringAsync("market/all", "isDetails=true");
            List<MarketEntity> markets = ConvertUtils.ConvertJsonToTList<MarketEntity>(result);
            /*
            var krwMarkets = from market in markets
                             where market.Market.IndexOf("KRW") != -1
                             select market;
            */

            Market domain = new Market();
            foreach (var market in markets)
            {
                domain.Add(market);
                Console.WriteLine(market.ToString());
            }

            string result2 = await Http.GetStringAsync("ticker", "markets=KRW-BTC,KRW-ADA");
            
            Console.WriteLine(result2);
        }

        //API
        //https://api.upbit.com/v1/market/all?isDetails=false
    }
}
