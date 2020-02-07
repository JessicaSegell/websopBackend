﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace hatShopApi.Migrations
{
    [DbContext(typeof(HatContext))]
    [Migration("20200206121750_Intial")]
    partial class Intial
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
                            hatName = "Hatt(1)",
                            hatPrice = 100,
                            hatText = "Lorem ipsum",
                            imgStr = ""
                        },
                        new
                        {
                            Id = 2,
                            hatName = "Hatt(1)",
                            hatPrice = 100,
                            hatText = "Lorem ipsum",
                            imgStr = ""
                        },
                        new
                        {
                            Id = 3,
                            hatName = "Hatt(1)",
                            hatPrice = 100,
                            hatText = "Lorem ipsum",
                            imgStr = ""
                        },
                        new
                        {
                            Id = 4,
                            hatName = "Hatt(1)",
                            hatPrice = 100,
                            hatText = "Lorem ipsum",
                            imgStr = ""
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