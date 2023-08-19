﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tech.Data;

namespace Tech.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230819170925_Area Add")]
    partial class AreaAdd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Tech.Areas.HrAddress.Models.EmpInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DistrictId");

                    b.Property<int>("DivisionId");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<int>("EmpCode");

                    b.Property<string>("EmpEnName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PhoneNumber");

                    b.Property<int>("ThanaId");

                    b.HasKey("Id");

                    b.HasIndex("DistrictId");

                    b.HasIndex("DivisionId");

                    b.HasIndex("ThanaId");

                    b.ToTable("EmpInfos");
                });

            modelBuilder.Entity("Tech.Areas.HrAddress.Models.HrDistrict", b =>
                {
                    b.Property<int>("DistrictId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BnName");

                    b.Property<string>("EnName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("DistrictId");

                    b.ToTable("HrDistricts");
                });

            modelBuilder.Entity("Tech.Areas.HrAddress.Models.HrDivision", b =>
                {
                    b.Property<int>("DivisionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BnName");

                    b.Property<string>("EnName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("DivisionId");

                    b.ToTable("HrDivisions");
                });

            modelBuilder.Entity("Tech.Areas.HrAddress.Models.HrThana", b =>
                {
                    b.Property<int>("ThanaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BnName");

                    b.Property<string>("EnName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ThanaId");

                    b.ToTable("HrThanas");
                });

            modelBuilder.Entity("Tech.Models.AuthorInfo", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .IsRequired();

                    b.HasKey("AuthorId");

                    b.ToTable("AuthorInfos");
                });

            modelBuilder.Entity("Tech.Models.BookInfo", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId");

                    b.Property<string>("name")
                        .IsRequired();

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.ToTable("BookInfos");
                });

            modelBuilder.Entity("Tech.Models.Color", b =>
                {
                    b.Property<int>("ColorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("bnName");

                    b.Property<string>("enName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("ColorId");

                    b.ToTable("colors");
                });

            modelBuilder.Entity("Tech.Models.PriceRange", b =>
                {
                    b.Property<int>("PriceRangeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("enName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("PriceRangeId");

                    b.ToTable("priceRanges");
                });

            modelBuilder.Entity("Tech.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ColorId");

                    b.Property<int>("ManufracturingAddressId");

                    b.Property<int?>("PriceRangeId");

                    b.Property<int?>("ProductionYearId");

                    b.Property<int>("UnitId");

                    b.Property<string>("bnName");

                    b.Property<string>("enName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.HasIndex("PriceRangeId");

                    b.HasIndex("ProductionYearId");

                    b.HasIndex("UnitId");

                    b.ToTable("products");
                });

            modelBuilder.Entity("Tech.Models.ProductUnit", b =>
                {
                    b.Property<int>("UnitId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("bnName");

                    b.Property<string>("enName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("UnitId");

                    b.ToTable("productUnits");
                });

            modelBuilder.Entity("Tech.Models.ProductionYear", b =>
                {
                    b.Property<int>("ProductionYearId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("bnName");

                    b.Property<string>("enName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("ProductionYearId");

                    b.ToTable("productionYears");
                });

            modelBuilder.Entity("Tech.Areas.HrAddress.Models.EmpInfo", b =>
                {
                    b.HasOne("Tech.Areas.HrAddress.Models.HrDistrict", "HrDistrict")
                        .WithMany("EmpInfos")
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Tech.Areas.HrAddress.Models.HrDivision", "HrDivision")
                        .WithMany("EmpInfos")
                        .HasForeignKey("DivisionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Tech.Areas.HrAddress.Models.HrThana", "HrThana")
                        .WithMany("EmpInfos")
                        .HasForeignKey("ThanaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Tech.Models.BookInfo", b =>
                {
                    b.HasOne("Tech.Models.AuthorInfo", "AuthorInfo")
                        .WithMany("bookInfos")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Tech.Models.Product", b =>
                {
                    b.HasOne("Tech.Models.Color", "Color")
                        .WithMany("Products")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Tech.Models.PriceRange")
                        .WithMany("Products")
                        .HasForeignKey("PriceRangeId");

                    b.HasOne("Tech.Models.ProductionYear")
                        .WithMany("Products")
                        .HasForeignKey("ProductionYearId");

                    b.HasOne("Tech.Models.ProductUnit", "ProductUnit")
                        .WithMany("Products")
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
