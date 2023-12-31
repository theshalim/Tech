﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tech.Data;

namespace Tech.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

            modelBuilder.Entity("Tech.Models.ManufracturingAddress", b =>
                {
                    b.Property<int>("ManufracturingAddressId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("bnName");

                    b.Property<string>("enName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("ManufracturingAddressId");

                    b.ToTable("manufracturingAddresses");
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

                    b.HasIndex("ManufracturingAddressId");

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

            modelBuilder.Entity("Tech.Models.Product", b =>
                {
                    b.HasOne("Tech.Models.Color", "Color")
                        .WithMany("Products")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Tech.Models.ManufracturingAddress", "ManufracturingAddress")
                        .WithMany("Products")
                        .HasForeignKey("ManufracturingAddressId")
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
