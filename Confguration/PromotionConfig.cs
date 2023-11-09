using createDataBaseWithCode.Entyties;
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
    internal class PromotionConfig : IEntityTypeConfiguration<Promotion>
    {
        public void Configure(EntityTypeBuilder<Promotion> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasMany(e => e.OrderLines).WithOne(e => e.Promotion).HasForeignKey(e => e.PromotionId);

            builder.HasData(GetAll());
        
        }
        public static List<Promotion> GetAll()
        {
            return new List<Promotion>()
            {
                new Promotion { Id = 1,vendor="mohmed Hamdi"},
                  new Promotion { Id = 2,vendor="mohmed Hamdi"}
            };
        }
    }
}
