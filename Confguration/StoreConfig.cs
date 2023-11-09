using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreModel.Entyties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreModel.Confguration
{
    internal class StoreConfig : IEntityTypeConfiguration<Store>
    {

        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.name).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.City).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.ZipCode).HasColumnType("varchar").HasMaxLength(8);
            builder.Property(x => x.State).HasColumnType("varchar").HasMaxLength(20);
            builder.Property(x => x.Telephone).HasColumnType("varchar").HasMaxLength(30);
            builder.HasMany(e => e.orders).WithOne(e => e.Store).HasForeignKey(e => e.Storeid);


            builder.HasData(DataStrore());

        }


       
        public  List<Store> DataStrore()
        {
            return new List<Store>
        {
            new Store {id=1,name="CairoStore",City="cairo",State="Egypt",ZipCode="082",Telephone="0822501274"},
             new Store {id=2,name="BenisuefStore",City="Benisue",State="Egypt",ZipCode="072",Telephone="0722551264"}
        };
        }
    }

}
