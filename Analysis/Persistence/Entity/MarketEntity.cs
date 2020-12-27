using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Entity
{
    public class MarketEntity
    {
        public virtual string Market_Warning { get; set; }
        public virtual string Market { get; set; }
        public virtual string Korean_Name { get; set; }
        public virtual string English_Name { get; set; }

        public override string ToString()
        {
            return $"시장: {Market}, 한국: {Korean_Name}, 영어:{English_Name}";
        }
    }
}
