using NHibernate;
using Persistence.Domain.Interface;
using Persistence.Entity;
using System;
using System.Collections.Generic;

namespace Persistence.Domain.Implement
{
    public class Market : IMarket
    {
        public bool Add(MarketEntity market)
        {
            try
            {
                using (ISession session = Helper.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(market);
                        transaction.Commit();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception : {e.ToString()}");
                return false;
            }

            return true;
        }

        public List<MarketEntity> Get()
        {
            throw new NotImplementedException();
        }

        public List<MarketEntity> GetByEnglishName(string name)
        {
            throw new NotImplementedException();
        }

        public List<MarketEntity> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public List<MarketEntity> GetByKoreanName(string name)
        {
            throw new NotImplementedException();
        }

        public bool Remove(MarketEntity market)
        {
            throw new NotImplementedException();
        }

        public bool Update(MarketEntity market)
        {
            throw new NotImplementedException();
        }
    }
}
