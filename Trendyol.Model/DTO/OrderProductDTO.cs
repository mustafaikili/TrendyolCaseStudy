using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyol.Core.Entities;

namespace Trendyol.Model.DTO
{
    public class OrderProductDTO : IEntity
    {
        public Guid OrderID { get; set; }
        public Guid ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public bool Store { get; set; }
        public bool Operating { get; set; }
        public bool EndOrder { get; set; }
    }
}
