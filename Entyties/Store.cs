using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreModel.Entyties
{
    public class Store
    {
        public int id { get; set; }
        public string name { get; set; }
        public string City { get; set; }
        public string? State { get; set; }
        public string ZipCode { get; set; }
        public string Telephone { set; get; }

        public ICollection<Order> orders { get; set; }=new List<Order>();
    } 
}
