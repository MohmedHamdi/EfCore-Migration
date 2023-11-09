using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using StoreModel.Entyties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreModel.Confguration
{
    internal class Orderconfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
             builder.HasKey(e => e.OrderId);
            

            builder.HasData(GetAll());
           

            
        }
        public static List<Order> GetAll()
        {
            return new List<Order>()
            {
                    new Order {OrderId=1,Storeid=1},
              new Order {OrderId=2,Storeid=2}
            };
        }
      
    }
}
