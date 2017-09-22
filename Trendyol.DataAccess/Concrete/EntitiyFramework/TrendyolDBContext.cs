using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyol.Model.Entities;
using Trendyol.Model.Mapping.EntityFramework;

namespace Trendyol.DataAccess.Concrete.EntitiyFramework
{
    public class TrendyolDBContext : DbContext
    {
        public TrendyolDBContext()
               : base("Server=.;Database=TrendyolCaseStudyDB;Integrated Security=True")
          {
              Database.SetInitializer<TrendyolDBContext>(new DropCreateDatabaseIfModelChanges<TrendyolDBContext>());
          }

        public DbSet<Products> Product { get; set; }
        public DbSet<Orders> Order { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductsMap());
            modelBuilder.Configurations.Add(new OrdersMap());
        }
         
    }
}
