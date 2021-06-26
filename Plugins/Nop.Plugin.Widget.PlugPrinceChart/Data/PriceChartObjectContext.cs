using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nop.Data;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Nop.Plugin.Widget.PlugPrinceChart.Data
{
    public class PriceChartObjectContext : DbContext, IDbContext
    {
        public PriceChartObjectContext(string nameOrConnectionString) : base(nameOrConnectionString) { }

        #region Implementation of IDbContext

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PriceChartRecordMap());
            base.OnModelCreating(modelBuilder);
        }

        public void Install()
        {
            Database.SetInitializer<PriceChartObjectContext>(null);
            Database.ExecuteSqlCommand(CreateDatabaseInstallationScript());
        }
        public void Uninstall()
        {
            var dbScript = "DROP TABLE price Chart";
            Database.ExecuteSqlCommand(dbScript);
            SaveChanges();
        }

        public new  IDbSet<TEntity> Set<TEntity>() where TEntity : Core.BaseEntity
        {
            return base.Set<TEntity>();
        }

        public System.Collections.Generic.IList<TEntity> ExequteStoredProcedureList<TEntity>(string commandText, params object[] parameters) where TEntity : Core.BaseEntity, new()
        {
            throw new System.NotImplementedException();
        }


        public string CreateDatabaseInstallationScript()
        {
            return ((System.Data.Entity.Infrastructure.IObjectContextAdapter)this).ObjectContext.CreateDatabaseScript();
        }
        bool IDbContext.ProxyCreationEnabled { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        bool IDbContext.AutoDetectChangesEnabled { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void IDbContext.Detach(object entity)
        {
            throw new NotImplementedException();
        }

        int IDbContext.ExecuteSqlCommand(string sql, bool doNotEnsureTransaction, int? timeout, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        IList<TEntity> IDbContext.ExecuteStoredProcedureList<TEntity>(string commandText, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        int IDbContext.SaveChanges()
        {
            throw new NotImplementedException();
        }

        IDbSet<TEntity> IDbContext.Set<TEntity>()
        {
            throw new NotImplementedException();
        }

        IEnumerable<TElement> IDbContext.SqlQuery<TElement>(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
