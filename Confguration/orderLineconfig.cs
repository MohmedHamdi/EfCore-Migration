using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreModel.Entyties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreModel.Confguration
{
    public class orderLineconfig : IEntityTypeConfiguration<OrderLine>
    {
        public void Configure(EntityTypeBuilder<OrderLine> builder)
        {
            builder.HasKey(e => e.itemId);
            builder.HasKey(e => e.orderID);
        builder.HasOne(e=>e.Item).WithMany(e=>e.OrderLine).HasForeignKey(x=>x.itemId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.orders).WithMany(e => e.OrderLines).HasForeignKey(x => x.orderID).OnDelete(DeleteBehavior.Cascade);
            builder.HasData(Get());
            
        }
        public static List<OrderLine> Get()
        {
            return new List<OrderLine>()
            {
                new OrderLine() {itemId=1, orderID=1,PromotionId=1},
                 new OrderLine() {itemId=2, orderID=2,PromotionId=2}
            };
        }
    }
}
