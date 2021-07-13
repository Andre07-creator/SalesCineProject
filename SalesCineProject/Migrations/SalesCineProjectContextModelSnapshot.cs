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

            modelBuilder.Entity("SalesCineProject.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Hour");

                    b.Property<string>("Name");

                    b.Property<int?>("TicketId");

                    b.HasKey("Id");

                    b.HasIndex("TicketId");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("SalesCineProject.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Client");

                    b.Property<DateTime>("Date");

                    b.Property<int>("MovieId");

                    b.Property<int>("Payment");

                    b.Property<double>("Price");

                    b.HasKey("Id");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("SalesCineProject.Models.Movie", b =>
                {
                    b.HasOne("SalesCineProject.Models.Ticket", "Ticket")
                        .WithMany("Movies")
                        .HasForeignKey("TicketId");
                });
#pragma warning restore 612, 618
        }
    }
}
