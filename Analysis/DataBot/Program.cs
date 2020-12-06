using DataBot.Utils;
using System;
using System.Threading.Tasks;

// https://docs.microsoft.com/ko-kr/dotnet/csharp/tutorials/console-webapiclient

namespace DataBot
{
    class Program
    {
        //https://docs.microsoft.com/ko-kr/dotnet/csharp/programming-guide/concepts/async/

        static async Task Main(string[] args)
        {
            string result = await Http.GetStringAsync("market/all", "isDetails=false");
            string result2 = await Http.GetStringAsync("ticker", "markets=KRW-BTC,KRW-ADA");
            Console.WriteLine(result);
            Console.WriteLine(result2);
        }

        //API
        //https://api.upbit.com/v1/market/all?isDetails=false
    }
}
