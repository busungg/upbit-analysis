using Persistence.Entity;
using System.Collections.Generic;

namespace Persistence.Domain.Interface
{
    public interface IMarket
    {
        bool Add(MarketEntity market);
        bool Update(MarketEntity market);
        bool Remove(MarketEntity market);
        List<MarketEntity> Get();
        List<MarketEntity> GetById(string id);
        List<MarketEntity> GetByKoreanName(string name);
        List<MarketEntity> GetByEnglishName(string name);
    }
}
