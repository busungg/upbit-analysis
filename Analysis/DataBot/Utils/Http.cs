using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace DataBot.Utils
{
    public class Http
    {
        private const string baseURL = "https://api.upbit.com/v1";
        private static readonly HttpClient client;

        private Http() { }
        static Http()
        {
            client = new HttpClient();
        }

        public static async Task<string> GetStringAsync(string url, string query)
        {
            try
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string result = await client.GetStringAsync($"{baseURL}/{url}?{query}");
                return result;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
