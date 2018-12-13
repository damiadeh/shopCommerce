﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using shop.Data;

namespace shop.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    [Migration("20181202082008_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("shop.Data.Models.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("BrandId");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("shop.Data.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Phone");

                    b.Property<bool>("Verified");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("shop.Data.Models.Pcategory", b =>
                {
                    b.Property<int>("PcategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("PcategoryId");

                    b.ToTable("Pcategories");
                });

            modelBuilder.Entity("shop.Data.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("PcategoryID");

                    b.Property<decimal>("Price");

                    b.Property<int>("Quantity");

                    b.Property<decimal>("Rating");

                    b.Property<int>("SellerId");

                    b.Property<bool>("Status");

                    b.Property<string>("fImageUrl");

                    b.Property<string>("sImageUrl");

                    b.Property<string>("tImageUrl");

                    b.HasKey("ProductId");

                    b.HasIndex("BrandId");

                    b.HasIndex("PcategoryID");

                    b.HasIndex("SellerId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("shop.Data.Models.Scategory", b =>
                {
                    b.Property<int>("ScategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ScategoryId");

                    b.ToTable("Scategories");
                });

            modelBuilder.Entity("shop.Data.Models.Seller", b =>
                {
                    b.Property<int>("SellerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActivationCode");

                    b.Property<string>("Address");

                    b.Property<string>("BrandImageUrl");

                    b.Property<string>("Dob");

                    b.Property<string>("Email");

                    b.Property<string>("FacebookName");

                    b.Property<string>("FacebookUrl");

                    b.Property<string>("FirstName");

                    b.Property<string>("IdCard");

                    b.Property<bool>("IdVerified");

                    b.Property<string>("InstagramName");

                    b.Property<string>("InstagramUrl");

                    b.Property<string>("Lastname");

                    b.Property<bool>("MailVerified");

                    b.Property<string>("MiddleName");

                    b.Property<string>("Password");

                    b.Property<string>("Phone");

                    b.Property<int>("ScategoryId");

                    b.Property<string>("ShopName");

                    b.Property<string>("TwitterName");

                    b.Property<string>("TwitterUrl");

                    b.HasKey("SellerId");

                    b.HasIndex("ScategoryId");

                    b.ToTable("Sellers");
                });

            modelBuilder.Entity("shop.Data.Models.Product", b =>
                {
                    b.HasOne("shop.Data.Models.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("shop.Data.Models.Pcategory", "Pcategory")
                        .WithMany("Products")
                        .HasForeignKey("PcategoryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("shop.Data.Models.Seller", "Seller")
                        .WithMany("Products")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("shop.Data.Models.Seller", b =>
                {
                    b.HasOne("shop.Data.Models.Scategory", "Scategory")
                        .WithMany("Sellers")
                        .HasForeignKey("ScategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
