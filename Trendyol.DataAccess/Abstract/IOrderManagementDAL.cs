using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyol.Core.DataAccess;
using Trendyol.Model.Entities;

namespace Trendyol.DataAccess.Abstract
{
    public  interface IOrderManagementDAL: IEntityRepository<Orders>
    {
    }
}
