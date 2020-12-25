using Newtonsoft.Json;
using System.Collections.Generic;

namespace DataBot.Utils
{
    public class ConvertUtils
    {
        public static List<T> ConvertJsonToTList<T>(string param)
        {
            return JsonConvert.DeserializeObject<List<T>>(param);
        }
    }
}
