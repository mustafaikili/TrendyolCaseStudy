using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyol.Model.Entities;

namespace Trendyol.Model.Mapping.EntityFramework
{
    public class ProductsMap: EntityTypeConfiguration<Products>
    {
        public ProductsMap()
        {
            //Primary KEY
            HasKey(x=>x.ProductID);

            //Property
            Property(x => x.ProductName).HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}
