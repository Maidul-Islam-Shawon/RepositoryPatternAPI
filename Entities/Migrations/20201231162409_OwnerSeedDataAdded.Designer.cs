﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entities.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20201231162409_OwnerSeedDataAdded")]
    partial class OwnerSeedDataAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.Account", b =>
                {
                    b.Property<Guid>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccountType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AccountId");

                    b.HasIndex("OwnerId");

                    b.ToTable("account");
                });

            modelBuilder.Entity("Entities.Models.Owner", b =>
                {
                    b.Property<Guid>("OwnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("OwnerId");

                    b.ToTable("owner");

                    b.HasData(
                        new
                        {
                            OwnerId = new Guid("8b4f98a4-7d0c-448e-a273-8f0fe04138b7"),
                            Address = "Dhaka",
                            DateOfBirth = new DateTime(1987, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Mohammed Salah"
                        },
                        new
                        {
                            OwnerId = new Guid("65061353-8db0-4d1c-a561-07bce550739a"),
                            Address = "Chittagong",
                            DateOfBirth = new DateTime(1981, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Joshim Shekh"
                        },
                        new
                        {
                            OwnerId = new Guid("0acbed4a-922a-4848-80e0-1f20e8f74d79"),
                            Address = "Barishal",
                            DateOfBirth = new DateTime(1985, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "MD Lutfur"
                        },
                        new
                        {
                            OwnerId = new Guid("84233508-d81b-4905-a559-361b797c2847"),
                            Address = "Dhaka",
                            DateOfBirth = new DateTime(1964, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Tom Hanks"
                        },
                        new
                        {
                            OwnerId = new Guid("2e11a8a7-ac21-4b9a-854f-57750e2c2091"),
                            Address = "Barishal",
                            DateOfBirth = new DateTime(1990, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "MD Lutfur"
                        });
                });

            modelBuilder.Entity("Entities.Models.Account", b =>
                {
                    b.HasOne("Entities.Models.Owner", "Owner")
                        .WithMany("Accounts")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
