﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaSPA.Server.DataStores;

namespace PizzaSPA.Server.Migrations
{
    [DbContext(typeof(PizzaPlaceDbContext))]
    [Migration("20190923162141_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0-rc1.19456.14");

            modelBuilder.Entity("PizzaSPA.Shared.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("PizzaSPA.Shared.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PizzaSPA.Shared.Pizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<int>("Spicyness")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Pizzas");
                });

            modelBuilder.Entity("PizzaSPA.Shared.PizzaOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PizzaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("PizzaId");

                    b.ToTable("PizzaOrders");
                });

            modelBuilder.Entity("PizzaSPA.Shared.Order", b =>
                {
                    b.HasOne("PizzaSPA.Shared.Customer", "Customer")
                        .WithOne("Order")
                        .HasForeignKey("PizzaSPA.Shared.Order", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PizzaSPA.Shared.PizzaOrder", b =>
                {
                    b.HasOne("PizzaSPA.Shared.Order", "Order")
                        .WithMany("PizzaOrders")
                        .HasForeignKey("OrderId");

                    b.HasOne("PizzaSPA.Shared.Pizza", "Pizza")
                        .WithMany("PizzaOrders")
                        .HasForeignKey("PizzaId");
                });
#pragma warning restore 612, 618
        }
    }
}
