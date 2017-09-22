using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyol.Model.Entities;

namespace Trendyol.Business.Abstruct
{
    public interface IOrderService
    {
        void Add(Orders order);
        ICollection<Orders> GetAll();
    }
}
