using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyol.Core.DataAccess.EntityFramework;
using Trendyol.DataAccess.Abstract.DTO;
using Trendyol.Model.DTO;

namespace Trendyol.DataAccess.Concrete.EntitiyFramework.DTO
{
    public class EFOrderProductDTO : EFEntityRepositoryBase<TrendyolDBContext, OrderProductDTO>, IOrderProductDTO
    {
        TrendyolDBContext context = SingletonContext<TrendyolDBContext>.Context;


        public ICollection<OrderProductDTO> GetAllDTO()
        {
            return (from p in context.Product
                    join o in context.Order
                    on p.ProductID equals o.ProductID
                    select new OrderProductDTO
                    {
                        OrderID = o.OrderID,
                        ProductID = p.ProductID,
                        ProductName = p.ProductName,
                        UnitPrice = p.UnitPrice,
                        Quantity = o.Quantity,
                        Store = o.Store,
                        Operating = o.Operating,
                        EndOrder = o.EndOrder
                    }
                    ).ToList();
        }
    }
}
