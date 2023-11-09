using createDataBaseWithCode.Entyties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreModel.Entyties
{
    public class OrderLine
    {
        public int orderID { get; set; }
        public int itemId { set; get; }
        public int PromotionId{ set; get; }
        public Order? orders { get; set; }
        public Item? Item { get; set; }
        public Promotion ?Promotion { get; set; }    
    }
}
