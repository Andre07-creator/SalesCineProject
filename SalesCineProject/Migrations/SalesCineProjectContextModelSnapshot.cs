﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesCineProject.Models;

namespace SalesCineProject.Migrations
{
    [DbContext(typeof(SalesCineProjectContext))]
    partial class SalesCineProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SalesCineProject.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("SalesCineProject.Models.SalesRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<int>("Payment");

                    b.Property<double>("Price");

                    b.HasKey("Id");

                    b.ToTable("SalesRecord");
                });

            modelBuilder.Entity("SalesCineProject.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientId");

                    b.Property<int>("Hour");

                    b.Property<string>("NameMovie");

                    b.Property<int>("SalesRecordId");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("SalesRecordId");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("SalesCineProject.Models.Ticket", b =>
                {
                    b.HasOne("SalesCineProject.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SalesCineProject.Models.SalesRecord", "SalesRecord")
                        .WithMany()
                        .HasForeignKey("SalesRecordId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
