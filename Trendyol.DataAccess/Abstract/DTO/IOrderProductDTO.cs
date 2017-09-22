using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyol.Model.DTO;

namespace Trendyol.DataAccess.Abstract.DTO
{
    public interface IOrderProductDTO
    {
        ICollection<OrderProductDTO> GetAllDTO();
    }
}
