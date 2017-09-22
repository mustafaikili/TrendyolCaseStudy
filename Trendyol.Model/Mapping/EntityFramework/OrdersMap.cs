using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyol.Model.Entities;

namespace Trendyol.Model.Mapping.EntityFramework
{
    public class OrdersMap : EntityTypeConfiguration<Orders>
    {
        public OrdersMap()
        {
            //Primary KEY
            HasKey(x=>x.OrderID);

            //Property

            //Foreign KEY
            HasRequired(x => x.Product).WithMany(x => x.Order).HasForeignKey(x => x.ProductID);


        }
    }
}
