using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyol.Core.Entities;

namespace Trendyol.Model.Entities
{
    public  class Products :IEntity
    {
        public Guid ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public bool IsActive { get; set; }

        //Navigation Properrty
        public ICollection<Orders> Order { get; set; }
    }
}
