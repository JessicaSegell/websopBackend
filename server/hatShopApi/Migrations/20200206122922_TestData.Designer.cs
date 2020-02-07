﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace hatShopApi.Migrations
{
    [DbContext(typeof(HatContext))]
    [Migration("20200206122922_TestData")]
    partial class TestData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("HatId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("HatId");

                    b.HasIndex("OrderId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Hat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("hatName")
                        .HasColumnType("TEXT");

                    b.Property<int>("hatPrice")
                        .HasColumnType("INTEGER");

                    b.Property<string>("hatText")
                        .HasColumnType("TEXT");

                    b.Property<string>("imgStr")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Hats");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            hatName = "Hashtag Hat",
                            hatPrice = 100,
                            hatText = "Keep warm while tweeting",
                            imgStr = "http://t0.gstatic.com/images?q=tbn%3AANd9GcRvO9UDf-3_pYJ8-krePNKiwm-D73OtdZan9ETILEIDwlQO18VxvZQgGZlaex4&usqp=CAc"
                        },
                        new
                        {
                            Id = 2,
                            hatName = "200",
                            hatPrice = 100,
                            hatText = "Let people know you are OK",
                            imgStr = "http://t0.gstatic.com/images?q=tbn%3AANd9GcTBv6cqMX7yBTcT_GKOTFVLlx1QZd2oUYz4kVPzS6Y8_sWvKqOi14SfCbBiq00dlsE40jxh2yY&usqp=CAc"
                        },
                        new
                        {
                            Id = 3,
                            hatName = "new MyHat()",
                            hatPrice = 100,
                            hatText = "This is an instance of a hat",
                            imgStr = "http://t0.gstatic.com/images?q=tbn%3AANd9GcQgqMJlq9uu9m9EVmm5ytER2-h68fXvFkBwdrjxwVMFzOY4v713l-VZVTsLPS8aS43O9TXkzsq-&usqp=CAc"
                        },
                        new
                        {
                            Id = 4,
                            hatName = "I Am Hat",
                            hatPrice = 100,
                            hatText = "This hat is self aware",
                            imgStr = "http://t0.gstatic.com/images?q=tbn%3AANd9GcT8zZNXpCSXXRFd8bF5ED2jwQv6Iym_SExvExyBppUlv0574IMMSG9SRg3l3bA_P6Z774FE5e4P&usqp=CAc"
                        });
                });

            modelBuilder.Entity("Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Total")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("CartItem", b =>
                {
                    b.HasOne("Hat", "Hat")
                        .WithMany()
                        .HasForeignKey("HatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Order", "Order")
                        .WithMany("CartItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
