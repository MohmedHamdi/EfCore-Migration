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
    internal class Itemconfig : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(e => e.ID);

            builder.Property(x => x.VendorName).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.description).HasColumnType("varchar").HasMaxLength(50).IsRequired();
           
            builder.HasData(GetAll());



        }
        public static List<Item> GetAll()
        {
            return new List<Item>()
            {
                    new Item {ID=1,VendorName="yasin ahmed",description="shipsy",price=12.3m},
               new Item {ID=2,VendorName="ali ahmed",description="pipc",price=225.3m},
            };
        }

    }
}
