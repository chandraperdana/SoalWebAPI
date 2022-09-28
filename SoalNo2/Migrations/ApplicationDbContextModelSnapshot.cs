﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SoalNo2.Data;

#nullable disable

namespace SoalNo2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SoalNo2.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Phone")
                        .HasColumnType("bigint");

                    b.Property<long>("Salary")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "chandra@gmail.com",
                            Name = "Chandra",
                            Phone = 12345678L,
                            Salary = 2000000L
                        },
                        new
                        {
                            Id = 2,
                            Email = "Dodi@gmail.com",
                            Name = "Dodi",
                            Phone = 12245678L,
                            Salary = 4000000L
                        },
                        new
                        {
                            Id = 3,
                            Email = "agus@gmail.com",
                            Name = "Agus",
                            Phone = 12366678L,
                            Salary = 3000000L
                        },
                        new
                        {
                            Id = 4,
                            Email = "taufik@gmail.com",
                            Name = "Taufik",
                            Phone = 12345888L,
                            Salary = 6000000L
                        },
                        new
                        {
                            Id = 5,
                            Email = "retno@gmail.com",
                            Name = "Retno",
                            Phone = 123433333L,
                            Salary = 5000000L
                        },
                        new
                        {
                            Id = 6,
                            Email = "tyas@gmail.com",
                            Name = "Tyas",
                            Phone = 15555678L,
                            Salary = 2400000L
                        },
                        new
                        {
                            Id = 7,
                            Email = "ryan@gmail.com",
                            Name = "Ryan",
                            Phone = 1111345678L,
                            Salary = 7100000L
                        },
                        new
                        {
                            Id = 8,
                            Email = "rino@gmail.com",
                            Name = "Rino",
                            Phone = 14444678L,
                            Salary = 3200000L
                        },
                        new
                        {
                            Id = 9,
                            Email = "aji@gmail.com",
                            Name = "Aji",
                            Phone = 66665678L,
                            Salary = 9000000L
                        },
                        new
                        {
                            Id = 10,
                            Email = "ani@gmail.com",
                            Name = "Ani",
                            Phone = 18885678L,
                            Salary = 3500000L
                        });
                });
#pragma warning restore 612, 618
        }
    }
}