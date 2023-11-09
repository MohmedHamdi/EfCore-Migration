using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreModel.Entyties
{
    public class Order
    {
        public int OrderId { set; get; }
        
        public int  Storeid { set; get; }
        public Store Store { set; get; }
        
        public ICollection<OrderLine>? OrderLines { set; get; }
    }
}
