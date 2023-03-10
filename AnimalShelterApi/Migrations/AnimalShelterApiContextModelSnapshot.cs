// <auto-generated />
using System;
using AnimalShelterApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterApiContext))]
    partial class AnimalShelterApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("varchar(75)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Date = new DateTime(2023, 2, 20, 14, 12, 52, 661, DateTimeKind.Local).AddTicks(9627),
                            Description = "Hard worker but tiny hands. Has weird cravings for other dino buddies.",
                            Name = "Bob the Rex",
                            Type = "Dino"
                        },
                        new
                        {
                            AnimalId = 2,
                            Date = new DateTime(2023, 2, 20, 14, 12, 52, 661, DateTimeKind.Local).AddTicks(9659),
                            Description = "No leaf is safe with bessy on the field. Could be the next NBA star for the dino leagues.",
                            Name = "Bessy the Longneck",
                            Type = "Dino"
                        },
                        new
                        {
                            AnimalId = 3,
                            Date = new DateTime(2023, 2, 20, 14, 12, 52, 661, DateTimeKind.Local).AddTicks(9661),
                            Description = "Like to spend a lot of time underneath shade and strictly planet based. Doesn't like it because of how fierce their horns are.",
                            Name = "Pierre, with bullhorns",
                            Type = "Dino"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
