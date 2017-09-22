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
    public class EFOrderManagementBLL : IOrderService
    {
        EFOrderManagementDAL _orderManagementDAL = new EFOrderManagementDAL();

        public void Add(Orders order)
        {
            _orderManagementDAL.Add(order);
        }
        public ICollection<Orders> GetAll()
        {
            return _orderManagementDAL.GetAll();
        }
    }
}
