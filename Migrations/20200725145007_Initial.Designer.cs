﻿// <auto-generated />
using System;
using JWTTest;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JWTTest.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200725145007_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JWTTest.Models.Pais", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Habitantes")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Paises");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fdfc67e3-6707-4b2e-a471-16555a24c619"),
                            Habitantes = 46000000,
                            Nombre = "España"
                        },
                        new
                        {
                            Id = new Guid("267e944e-ac88-4ee3-af04-8cb6161bf470"),
                            Habitantes = 83000000,
                            Nombre = "Alemania"
                        },
                        new
                        {
                            Id = new Guid("27ab0c03-ec6f-4e1e-8d85-7b77d4d723fb"),
                            Habitantes = 65000000,
                            Nombre = "Francia"
                        },
                        new
                        {
                            Id = new Guid("24a89b1b-c910-44dc-96db-09b300e3f549"),
                            Habitantes = 61000000,
                            Nombre = "Italia"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
