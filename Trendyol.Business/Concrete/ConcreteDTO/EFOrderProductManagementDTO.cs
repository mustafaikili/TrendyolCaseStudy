using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyol.Business.Abstruct.AbstructDTO;
using Trendyol.DataAccess.Concrete.EntitiyFramework.DTO;
using Trendyol.Model.DTO;

namespace Trendyol.Business.Concrete.ConcreteDTO
{
    public class EFOrderProductManagementDTO : IOrderProductService
    {
        EFOrderProductDTO _orderProductDTO = new EFOrderProductDTO();

         ICollection<OrderProductDTO> IOrderProductService.orderProductName()
        {
            return _orderProductDTO.GetAllDTO();
        }
    }
}
