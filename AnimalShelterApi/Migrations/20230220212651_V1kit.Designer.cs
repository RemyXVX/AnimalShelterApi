// <auto-generated />
using System;
using AnimalShelterApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterApiContext))]
    [Migration("20230220212651_V1kit")]
    partial class V1kit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelterApi.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Date = new DateTime(2023, 2, 20, 13, 26, 51, 374, DateTimeKind.Local).AddTicks(6240),
                            Description = "Hard worker but tiny hands. Has weird cravings for other dino buddies.",
                            Name = "Bob the Rex",
                            Type = "mr_hans"
                        },
                        new
                        {
                            AnimalId = 2,
                            Date = new DateTime(2023, 2, 20, 13, 26, 51, 374, DateTimeKind.Local).AddTicks(6275),
                            Description = "No leaf is safe with bessy on the field. Could be the next NBA star for the dino leagues.",
                            Name = "Bessy the Longneck",
                            Type = "mr_hans"
                        },
                        new
                        {
                            AnimalId = 3,
                            Date = new DateTime(2023, 2, 20, 13, 26, 51, 374, DateTimeKind.Local).AddTicks(6278),
                            Description = "Like to spend a lot of time underneath shade and strictly planet based. Doesn't like it because of how fierce their horns are.",
                            Name = "Pierre, with bullhorns",
                            Type = "mr_hans"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
