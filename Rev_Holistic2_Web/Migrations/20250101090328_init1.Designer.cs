﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rev_Holistic2_Web.Data;

#nullable disable

namespace Rev_Holistic2_Web.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250101090328_init1")]
    partial class init1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Rev_Holistic2_Web.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Rev_Holistic2_Web.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Rev_Holistic2_Web.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Rev_Holistic2_Web.Models.ShoppingCart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfItems")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique()
                        .HasFilter("[CustomerId] IS NOT NULL");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("Rev_Holistic2_Web.Models.Order", b =>
                {
                    b.HasOne("Rev_Holistic2_Web.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Rev_Holistic2_Web.Models.Product", b =>
                {
                    b.HasOne("Rev_Holistic2_Web.Models.Order", "Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderId");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Rev_Holistic2_Web.Models.ShoppingCart", b =>
                {
                    b.HasOne("Rev_Holistic2_Web.Models.Customer", "Customer")
                        .WithOne("ShoppingCart")
                        .HasForeignKey("Rev_Holistic2_Web.Models.ShoppingCart", "CustomerId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Rev_Holistic2_Web.Models.Customer", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("ShoppingCart");
                });

            modelBuilder.Entity("Rev_Holistic2_Web.Models.Order", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
