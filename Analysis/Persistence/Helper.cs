using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace Persistence
{
    public class Helper
    {
        private static Configuration _configuration;
        private static ISessionFactory _sessionFactory;

        static Helper() {
            //https://stackoverflow.com/questions/3451761/getting-fluent-nhibernate-to-build-database-tables
            _configuration = new Configuration().Configure();
            var exporter = new SchemaExport(_configuration);
            exporter.Execute(true, true, false);
        }
        
        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    _sessionFactory = _configuration.BuildSessionFactory();
                }
                return _sessionFactory;
            }
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
