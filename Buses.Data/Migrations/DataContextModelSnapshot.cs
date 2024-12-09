﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Buses.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Buses.Core.classes.Bus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Company")
                        .HasColumnType("int");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StationId")
                        .HasColumnType("int");

                    b.Property<int>("TimingsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StationId");

                    b.HasIndex("TimingsId");

                    b.ToTable("buses");
                });

            modelBuilder.Entity("Buses.Core.classes.Station", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("StationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StreetId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StreetId");

                    b.ToTable("stations");
                });

            modelBuilder.Entity("Buses.Core.classes.StationAndi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BusId")
                        .HasColumnType("int");

                    b.Property<int>("BusStopId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BusId");

                    b.HasIndex("BusStopId");

                    b.ToTable("StationAndi");
                });

            modelBuilder.Entity("Buses.Core.classes.Street", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("streets");
                });

            modelBuilder.Entity("Buses.Core.classes.TimeOfBus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("TimeOfBus");
                });

            modelBuilder.Entity("Buses.Core.classes.Bus", b =>
                {
                    b.HasOne("Buses.Core.classes.Station", null)
                        .WithMany("BusInStation")
                        .HasForeignKey("StationId");

                    b.HasOne("Buses.Core.classes.TimeOfBus", "Timings")
                        .WithMany()
                        .HasForeignKey("TimingsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Timings");
                });

            modelBuilder.Entity("Buses.Core.classes.Station", b =>
                {
                    b.HasOne("Buses.Core.classes.Street", null)
                        .WithMany("ListOfStation")
                        .HasForeignKey("StreetId");
                });

            modelBuilder.Entity("Buses.Core.classes.StationAndi", b =>
                {
                    b.HasOne("Buses.Core.classes.Bus", null)
                        .WithMany("Listofstation")
                        .HasForeignKey("BusId");

                    b.HasOne("Buses.Core.classes.Station", "BusStop")
                        .WithMany()
                        .HasForeignKey("BusStopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BusStop");
                });

            modelBuilder.Entity("Buses.Core.classes.Bus", b =>
                {
                    b.Navigation("Listofstation");
                });

            modelBuilder.Entity("Buses.Core.classes.Station", b =>
                {
                    b.Navigation("BusInStation");
                });

            modelBuilder.Entity("Buses.Core.classes.Street", b =>
                {
                    b.Navigation("ListOfStation");
                });
#pragma warning restore 612, 618
        }
    }
}
