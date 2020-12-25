using System;
using System.Collections.Generic;
using System.Text;

namespace DataBot.Model
{
    public class MarketModel
    {
        public string Market_Warning { get; set; }
        public string Market { get; set; }
        public string Korean_Name { get; set; }
        public string English_Name { get; set; }

        public override string ToString()
        {
            return $"시장: {Market}, 한국: {Korean_Name}, 영어:{English_Name}";
        }
    }
}
