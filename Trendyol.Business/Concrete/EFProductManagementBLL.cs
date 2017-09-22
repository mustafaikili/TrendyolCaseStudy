using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyol.Business.Abstruct;
using Trendyol.DataAccess.Concrete.EntitiyFramework.DALManagement;
using Trendyol.Model.Entities;

namespace Trendyol.Business.Concrete
{

    public class EFProductManagementBLL : IProductService
    {
        EFProductManagementDAL _productManagementDAL = new EFProductManagementDAL();
        public ICollection<Products> GetAll()
        {
            return _productManagementDAL.GetAll();
        }
        public Products GetByProductID(Guid productID)
        {
            return _productManagementDAL.Get(x => x.ProductID == productID);
        }
        public void Add()
        {
        }


        public void Add(Products product)
        {
            _productManagementDAL.Add(product);
        }
    }
}
