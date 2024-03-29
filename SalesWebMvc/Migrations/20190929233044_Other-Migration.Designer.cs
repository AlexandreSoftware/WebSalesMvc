﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesWebMvc.Data;

namespace SalesWebMvc.Migrations
{
    [DbContext(typeof(SalesWebMvcContext))]
    [Migration("20190929233044_Other-Migration")]
    partial class OtherMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SalesWebMvc.Models.Department", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name");

                    b.HasKey("id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("SalesWebMvc.Models.SalesRecord", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("amount");

                    b.Property<DateTime>("date");

                    b.Property<int?>("sellerid");

                    b.Property<int>("status");

                    b.HasKey("id");

                    b.HasIndex("sellerid");

                    b.ToTable("SalesRecords");
                });

            modelBuilder.Entity("SalesWebMvc.Models.Seller", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("baseSalary");

                    b.Property<DateTime>("birthDate");

                    b.Property<int?>("departmentid");

                    b.Property<string>("email");

                    b.Property<string>("name");

                    b.HasKey("id");

                    b.HasIndex("departmentid");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("SalesWebMvc.Models.SalesRecord", b =>
                {
                    b.HasOne("SalesWebMvc.Models.Seller", "seller")
                        .WithMany("sales")
                        .HasForeignKey("sellerid");
                });

            modelBuilder.Entity("SalesWebMvc.Models.Seller", b =>
                {
                    b.HasOne("SalesWebMvc.Models.Department", "department")
                        .WithMany("sellers")
                        .HasForeignKey("departmentid");
                });
#pragma warning restore 612, 618
        }
    }
}
