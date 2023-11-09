using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreModel.Entyties
{
   public class Promotion
    {
        public int Id { get; set; } 
        public string vendor { get; set; }
        public ICollection<OrderLine>?  OrderLines{ get; set; }       
       
       
    }
}
