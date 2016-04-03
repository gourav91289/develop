using Repository.Providers.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace com.boutique.Data
{
    public partial class MyDatabaseContext : DbContextBase    
    {
        public MyDatabaseContext() :
           base("name=MyDatabaseContext")
        {
            //Database.SetInitializer<MyDatabaseContext>(new DropCreateDatabaseIfModelChanges<MyDatabaseContext>());
            Database.SetInitializer<MyDatabaseContext>(null);
            Configuration.ProxyCreationEnabled = false;

        }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new BoutiqueMap());           
            modelBuilder.Configurations.Add(new ParameterTypeMap());           
            modelBuilder.Configurations.Add(new CustomerDetailMap());
            modelBuilder.Configurations.Add(new StitchingItemMap());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
