using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyol.Model.Entities;

namespace Trendyol.Business.Abstruct
{
   public interface IProductService
    {
       ICollection<Products> GetAll();
       Products GetByProductID(Guid productID);
       void Add(Products product);
    }
}
