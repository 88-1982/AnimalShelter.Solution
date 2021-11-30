﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Solution.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    partial class AnimalShelterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AnimalShelter.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Markings")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 8,
                            Family = "SavannahCat",
                            Markings = "Black/Brown/Spotted",
                            Name = "Orion",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 7,
                            Family = "Husky",
                            Markings = "Male",
                            Name = "Thor",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 9,
                            Family = "unknown",
                            Markings = "Black/White/",
                            Name = "Loki",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 10,
                            Family = "Pomeranian",
                            Markings = "Brown",
                            Name = "Odin",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 7,
                            Family = "Pit-Bull",
                            Markings = "Black",
                            Name = "Zeus",
                            Species = "Dog"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
