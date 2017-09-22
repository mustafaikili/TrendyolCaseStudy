using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyol.Core.Entities;

namespace Trendyol.Model.Entities
{
    public class Orders: IEntity
    {
        public Guid OrderID { get; set; }
        public Guid ProductID { get; set; }
        public bool Store { get; set; }
        public int Quantity { get; set; }
        public bool Operating { get; set; }
        public bool EndOrder { get; set; }
        public bool IsActive { get; set; }
        
        //Navigation Property
        public virtual Products Product { get; set; }
    }
}
