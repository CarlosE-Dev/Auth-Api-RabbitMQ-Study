﻿// <auto-generated />
using System;
using Auth.UserActivity.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Auth.UserActivity.Infra.Migrations
{
    [DbContext(typeof(UserActivityContext))]
    partial class UserActivityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Auth.UserActivity.Domain.Models.UserActivityModel", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("LastAccess")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LastClientIP")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("RegisteredOn")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("SessionExpire")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserCompleteName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("UserId");

                    b.ToTable("AUA_USER_ACTIVITIES", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "55882d84-8e41-4ef6-9436-cc08cf6f4757",
                            LastAccess = new DateTime(2023, 4, 5, 13, 44, 49, 540, DateTimeKind.Local).AddTicks(7273),
                            LastClientIP = "181.11.1.1",
                            RegisteredOn = new DateTime(2023, 4, 5, 13, 44, 49, 540, DateTimeKind.Local).AddTicks(7968),
                            SessionExpire = new DateTime(2023, 4, 5, 14, 44, 49, 540, DateTimeKind.Local).AddTicks(8164),
                            UserCompleteName = "Maicon Andrews",
                            UserEmail = "maicon.andrew@mail.com"
                        },
                        new
                        {
                            UserId = "70c98565-b456-4e4b-97d8-7733c503a640",
                            LastAccess = new DateTime(2023, 4, 5, 13, 44, 49, 540, DateTimeKind.Local).AddTicks(9592),
                            LastClientIP = "181.11.1.1",
                            RegisteredOn = new DateTime(2023, 4, 5, 13, 44, 49, 540, DateTimeKind.Local).AddTicks(9598),
                            SessionExpire = new DateTime(2023, 4, 5, 14, 44, 49, 540, DateTimeKind.Local).AddTicks(9598),
                            UserCompleteName = "Matthew Anderson",
                            UserEmail = "matt.anderson@mail.com"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}