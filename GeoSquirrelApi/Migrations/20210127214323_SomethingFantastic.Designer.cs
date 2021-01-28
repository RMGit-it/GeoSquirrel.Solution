﻿// <auto-generated />
using System;
using GeoSquirrelApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GeoSquirrelApi.Migrations
{
    [DbContext(typeof(GeoSquirrelApiContext))]
    [Migration("20210127214323_SomethingFantastic")]
    partial class SomethingFantastic
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GeoSquirrelApi.Models.Cache", b =>
                {
                    b.Property<int>("CacheId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<decimal>("Latitude");

                    b.Property<decimal>("Longitude");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("CacheId");

                    b.ToTable("Caches");

                    b.HasData(
                        new
                        {
                            CacheId = 1,
                            DateCreated = new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Latitude = 45.5252m,
                            Longitude = -122.7163m,
                            Name = "Pittock Mansion"
                        },
                        new
                        {
                            CacheId = 2,
                            DateCreated = new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Latitude = 45.5051m,
                            Longitude = -122.6750m,
                            Name = "Portland"
                        },
                        new
                        {
                            CacheId = 3,
                            DateCreated = new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Latitude = 23.88888888m,
                            Longitude = 13.55888885m,
                            Name = "Location 3"
                        });
                });

            modelBuilder.Entity("GeoSquirrelApi.Models.CacheGamePlayer", b =>
                {
                    b.Property<int>("CacheGamePlayerId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CacheId");

                    b.Property<bool>("FoundCache");

                    b.Property<int>("GameId");

                    b.Property<int>("PlayerId");

                    b.HasKey("CacheGamePlayerId");

                    b.HasIndex("CacheId");

                    b.HasIndex("GameId");

                    b.HasIndex("PlayerId");

                    b.ToTable("CacheGamePlayers");
                });

            modelBuilder.Entity("GeoSquirrelApi.Models.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("GameId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("GeoSquirrelApi.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("PlayerId");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            PlayerId = 1,
                            Email = "svealinneawade@gmail.com",
                            Name = "Svea"
                        },
                        new
                        {
                            PlayerId = 2,
                            Email = "nathanschrader@icloud.com",
                            Name = "Nathan"
                        },
                        new
                        {
                            PlayerId = 3,
                            Email = "posten.coding@gmail.com",
                            Name = "Patrick"
                        },
                        new
                        {
                            PlayerId = 4,
                            Email = "randel.c.moore@gmail.com",
                            Name = "Randel"
                        });
                });

            modelBuilder.Entity("GeoSquirrelApi.Models.CacheGamePlayer", b =>
                {
                    b.HasOne("GeoSquirrelApi.Models.Cache", "Cache")
                        .WithMany()
                        .HasForeignKey("CacheId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GeoSquirrelApi.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GeoSquirrelApi.Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}