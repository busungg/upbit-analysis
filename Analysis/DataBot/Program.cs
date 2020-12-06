using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

// https://docs.microsoft.com/ko-kr/dotnet/csharp/tutorials/console-webapiclient

namespace DataBot
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        private static async Task Call()
        {
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var stringTask = client.GetStringAsync(@"https://api.upbit.com/v1/ticker?markets=KRW-BTC");

            var msg = await stringTask;
            Console.WriteLine(msg);
        }

        static async Task Main(string[] args)
        {
            await Call();
        }
    }
}
