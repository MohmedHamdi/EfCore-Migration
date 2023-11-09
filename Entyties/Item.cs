using StoreModel.Entyties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createDataBaseWithCode.Entyties
{
    public class Item
    {
        public int ID { set; get; }
        public string VendorName { set; get; }
        public string description { set; get; }
        public decimal price { set; get; }
        public ICollection<OrderLine> ?OrderLine { set; get; }
    }
}
