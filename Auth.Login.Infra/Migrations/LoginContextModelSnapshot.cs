﻿// <auto-generated />
using System;
using Auth.Login.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Auth.Login.Infra.Migrations
{
    [DbContext(typeof(LoginContext))]
    partial class LoginContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Auth.Login.Domain.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("AL_USERS", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "80d7e67d-c585-45a6-b608-01e3e3d07ae2",
                            CreatedOn = new DateTime(2023, 4, 6, 0, 44, 13, 309, DateTimeKind.Local).AddTicks(6047),
                            Email = "test@test.com",
                            FirstName = "James",
                            LastName = "Young",
                            Password = "test123"
                        },
                        new
                        {
                            Id = "3dfb450b-c204-4e5c-abda-202cc3c3259a",
                            CreatedOn = new DateTime(2023, 4, 6, 0, 44, 13, 309, DateTimeKind.Local).AddTicks(6690),
                            Email = "PPRUU@AOWSW.com",
                            FirstName = "KBGQG",
                            LastName = "SRCKD",
                            Password = "IMPEQWZS"
                        },
                        new
                        {
                            Id = "2d9bc878-4d56-4c75-bfae-f4e40a3e9f44",
                            CreatedOn = new DateTime(2023, 4, 6, 0, 44, 13, 311, DateTimeKind.Local).AddTicks(2538),
                            Email = "NDXUR@WSHKA.com",
                            FirstName = "BQVZS",
                            LastName = "VZOGF",
                            Password = "OOZYMYXR"
                        },
                        new
                        {
                            Id = "6bb9ce2e-b0cb-46db-b05d-34dbb7a6de14",
                            CreatedOn = new DateTime(2023, 4, 6, 0, 44, 13, 311, DateTimeKind.Local).AddTicks(2559),
                            Email = "DAKUI@CDINQ.com",
                            FirstName = "GBOCD",
                            LastName = "SANHA",
                            Password = "BDBJRVVU"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
