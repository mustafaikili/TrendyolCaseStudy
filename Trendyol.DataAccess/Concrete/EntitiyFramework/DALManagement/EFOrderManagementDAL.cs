using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyol.Core.DataAccess.EntityFramework;
using Trendyol.DataAccess.Abstract;
using Trendyol.DataAccess.Abstract.DTO;
using Trendyol.Model.Entities;

namespace Trendyol.DataAccess.Concrete.EntitiyFramework.DALManagement
{
    public class EFOrderManagementDAL : EFEntityRepositoryBase<TrendyolDBContext,Orders>,IOrderManagementDAL
    {

    }
}
