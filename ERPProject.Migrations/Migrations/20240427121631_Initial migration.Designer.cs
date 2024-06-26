﻿// <auto-generated />
using System;
using ERPProject.Migrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ERPProject.Migrations.Migrations
{
    [DbContext(typeof(ERPDatabaseContext))]
    [Migration("20240427121631_Initial migration")]
    partial class Initialmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ERPProject.Model.CustomerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatorUserId")
                        .HasColumnType("int");

                    b.Property<string>("CustomerAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CustomerMobile")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<DateTime?>("LastModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LastModifiedUserId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Identity", "0,1");

                    b.HasIndex("CreatorUserId");

                    b.HasIndex("CustomerEmail")
                        .IsUnique();

                    b.HasIndex("CustomerMobile")
                        .IsUnique();

                    b.HasIndex("LastModifiedUserId");

                    b.ToTable("Customers", "Person");
                });

            modelBuilder.Entity("ERPProject.Model.OrderDetailsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatorUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LastModifiedUserId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Identity", "0,1");

                    b.HasIndex("CreatorUserId");

                    b.HasIndex("LastModifiedUserId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails", "Order");
                });

            modelBuilder.Entity("ERPProject.Model.OrderModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatorUserId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LastModifiedUserId")
                        .HasColumnType("int");

                    b.Property<int>("OrderStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<float>("TotalAmount")
                        .HasColumnType("real");

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Identity", "0,1");

                    b.HasIndex("CreatorUserId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("LastModifiedUserId");

                    b.ToTable("Orders", "Order");
                });

            modelBuilder.Entity("ERPProject.Model.ProductModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatorUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LastModifiedUserId")
                        .HasColumnType("int");

                    b.Property<string>("ProductDescription")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<float>("ProductPurchasePrice")
                        .HasColumnType("real");

                    b.Property<float>("ProductSellingPrice")
                        .HasColumnType("real");

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Identity", "0,1");

                    b.HasIndex("CreatorUserId");

                    b.HasIndex("LastModifiedUserId");

                    b.HasIndex("ProductName")
                        .IsUnique();

                    b.ToTable("Products", "Store");
                });

            modelBuilder.Entity("ERPProject.Model.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatorUserId")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<DateTime?>("LastModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LastModifiedUserId")
                        .HasColumnType("int");

                    b.Property<string>("UserAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserMobile")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Identity", "0,1");

                    b.HasIndex("CreatorUserId");

                    b.HasIndex("LastModifiedUserId");

                    b.HasIndex("UserEmail")
                        .IsUnique();

                    b.HasIndex("UserMobile")
                        .IsUnique();

                    b.ToTable("Users", "Person");
                });

            modelBuilder.Entity("ERPProject.Model.CustomerModel", b =>
                {
                    b.HasOne("ERPProject.Model.UserModel", "CreatorUser")
                        .WithMany()
                        .HasForeignKey("CreatorUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ERPProject.Model.UserModel", "LastModifiedUser")
                        .WithMany()
                        .HasForeignKey("LastModifiedUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CreatorUser");

                    b.Navigation("LastModifiedUser");
                });

            modelBuilder.Entity("ERPProject.Model.OrderDetailsModel", b =>
                {
                    b.HasOne("ERPProject.Model.UserModel", "CreatorUser")
                        .WithMany()
                        .HasForeignKey("CreatorUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ERPProject.Model.UserModel", "LastModifiedUser")
                        .WithMany()
                        .HasForeignKey("LastModifiedUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ERPProject.Model.OrderModel", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ERPProject.Model.ProductModel", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CreatorUser");

                    b.Navigation("LastModifiedUser");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ERPProject.Model.OrderModel", b =>
                {
                    b.HasOne("ERPProject.Model.UserModel", "CreatorUser")
                        .WithMany()
                        .HasForeignKey("CreatorUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ERPProject.Model.CustomerModel", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ERPProject.Model.UserModel", "LastModifiedUser")
                        .WithMany()
                        .HasForeignKey("LastModifiedUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CreatorUser");

                    b.Navigation("Customer");

                    b.Navigation("LastModifiedUser");
                });

            modelBuilder.Entity("ERPProject.Model.ProductModel", b =>
                {
                    b.HasOne("ERPProject.Model.UserModel", "CreatorUser")
                        .WithMany()
                        .HasForeignKey("CreatorUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ERPProject.Model.UserModel", "LastModifiedUser")
                        .WithMany()
                        .HasForeignKey("LastModifiedUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CreatorUser");

                    b.Navigation("LastModifiedUser");
                });

            modelBuilder.Entity("ERPProject.Model.UserModel", b =>
                {
                    b.HasOne("ERPProject.Model.UserModel", "CreatorUser")
                        .WithMany()
                        .HasForeignKey("CreatorUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ERPProject.Model.UserModel", "LastModifiedUser")
                        .WithMany()
                        .HasForeignKey("LastModifiedUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CreatorUser");

                    b.Navigation("LastModifiedUser");
                });
#pragma warning restore 612, 618
        }
    }
}
