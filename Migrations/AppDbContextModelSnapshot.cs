﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreModel.Data;

#nullable disable

namespace StoreModel.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StoreModel.Entyties.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<int>("Storeid")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("Storeid");

                    b.ToTable("orders");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            Storeid = 1
                        },
                        new
                        {
                            OrderId = 2,
                            Storeid = 2
                        });
                });

            modelBuilder.Entity("StoreModel.Entyties.OrderLine", b =>
                {
                    b.Property<int>("orderID")
                        .HasColumnType("int");

                    b.Property<int>("PromotionId")
                        .HasColumnType("int");

                    b.Property<int>("itemId")
                        .HasColumnType("int");

                    b.HasKey("orderID");

                    b.HasIndex("PromotionId");

                    b.HasIndex("itemId");

                    b.ToTable("ordersLine");

                    b.HasData(
                        new
                        {
                            orderID = 1,
                            PromotionId = 1,
                            itemId = 1
                        },
                        new
                        {
                            orderID = 2,
                            PromotionId = 2,
                            itemId = 2
                        });
                });

            modelBuilder.Entity("StoreModel.Entyties.Promotion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("vendor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("promotion");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            vendor = "mohmed Hamdi"
                        },
                        new
                        {
                            Id = 2,
                            vendor = "mohmed Hamdi"
                        });
                });

            modelBuilder.Entity("StoreModel.Entyties.Store", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("State")
                        .HasMaxLength(20)
                        .HasColumnType("varchar");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("varchar");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.HasKey("id");

                    b.ToTable("stores");

                    b.HasData(
                        new
                        {
                            id = 1,
                            City = "cairo",
                            State = "Egypt",
                            Telephone = "0822501274",
                            ZipCode = "082",
                            name = "CairoStore"
                        },
                        new
                        {
                            id = 2,
                            City = "Benisue",
                            State = "Egypt",
                            Telephone = "0722551264",
                            ZipCode = "072",
                            name = "BenisuefStore"
                        });
                });

            modelBuilder.Entity("createDataBaseWithCode.Entyties.Item", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("VendorName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("items");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            VendorName = "yasin ahmed",
                            description = "shipsy",
                            price = 12.3m
                        },
                        new
                        {
                            ID = 2,
                            VendorName = "ali ahmed",
                            description = "pipc",
                            price = 225.3m
                        });
                });

            modelBuilder.Entity("StoreModel.Entyties.Order", b =>
                {
                    b.HasOne("StoreModel.Entyties.Store", "Store")
                        .WithMany("orders")
                        .HasForeignKey("Storeid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Store");
                });

            modelBuilder.Entity("StoreModel.Entyties.OrderLine", b =>
                {
                    b.HasOne("StoreModel.Entyties.Promotion", "Promotion")
                        .WithMany("OrderLines")
                        .HasForeignKey("PromotionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("createDataBaseWithCode.Entyties.Item", "Item")
                        .WithMany("OrderLine")
                        .HasForeignKey("itemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StoreModel.Entyties.Order", "orders")
                        .WithMany("OrderLines")
                        .HasForeignKey("orderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Promotion");

                    b.Navigation("orders");
                });

            modelBuilder.Entity("StoreModel.Entyties.Order", b =>
                {
                    b.Navigation("OrderLines");
                });

            modelBuilder.Entity("StoreModel.Entyties.Promotion", b =>
                {
                    b.Navigation("OrderLines");
                });

            modelBuilder.Entity("StoreModel.Entyties.Store", b =>
                {
                    b.Navigation("orders");
                });

            modelBuilder.Entity("createDataBaseWithCode.Entyties.Item", b =>
                {
                    b.Navigation("OrderLine");
                });
#pragma warning restore 612, 618
        }
    }
}
