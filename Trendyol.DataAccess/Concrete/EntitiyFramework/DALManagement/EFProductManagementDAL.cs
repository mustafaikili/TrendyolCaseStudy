using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyol.Core.DataAccess.EntityFramework;
using Trendyol.DataAccess.Abstract;
using Trendyol.Model.Entities;

namespace Trendyol.DataAccess.Concrete.EntitiyFramework.DALManagement
{
    public class EFProductManagementDAL: EFEntityRepositoryBase<TrendyolDBContext,Products>, IProductManagementDAL
    {
    }
}
