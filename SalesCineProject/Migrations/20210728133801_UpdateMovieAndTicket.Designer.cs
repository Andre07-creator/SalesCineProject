﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesCineProject.Models;

namespace SalesCineProject.Migrations
{
    [DbContext(typeof(SalesCineProjectContext))]
    [Migration("20210728133801_UpdateMovieAndTicket")]
    partial class UpdateMovieAndTicket
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.HasKey("Id");

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

                    b.HasIndex("MovieId");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("SalesCineProject.Models.Ticket", b =>
                {
                    b.HasOne("SalesCineProject.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}