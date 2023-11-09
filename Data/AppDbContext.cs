using createDataBaseWithCode.Entyties;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using StoreModel.Entyties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreModel.Data
{
    internal class AppDbContext:DbContext
    {
       public DbSet<Order> orders { set; get; }
        public DbSet<Store> stores { set; get; }
        public DbSet<OrderLine> ordersLine { set; get; }
        public DbSet<Item> items { set; get; }
        public DbSet<Promotion> promotion { set; get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var confiq=new ConfigurationBuilder()
                .AddJsonFile("appsetting.json").Build();
            var ConnectionString = confiq.GetSection("constr").Value;
            optionsBuilder.UseSqlServer(ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
