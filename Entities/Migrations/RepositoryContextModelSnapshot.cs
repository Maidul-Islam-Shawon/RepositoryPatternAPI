﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entities.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasData(
                        new
                        {
                            AccountId = new Guid("10c4f57d-5f70-4d4a-92a0-b8b7cf86ca13"),
                            AccountType = "Savings",
                            DateCreated = new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OwnerId = new Guid("8b4f98a4-7d0c-448e-a273-8f0fe04138b7")
                        },
                        new
                        {
                            AccountId = new Guid("7e34c9fa-7c7d-4307-be5e-52cf89e0450a"),
                            AccountType = "Current",
                            DateCreated = new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OwnerId = new Guid("65061353-8db0-4d1c-a561-07bce550739a")
                        },
                        new
                        {
                            AccountId = new Guid("a7445a4c-c368-4683-9906-ee32721e37a6"),
                            AccountType = "Current",
                            DateCreated = new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OwnerId = new Guid("0acbed4a-922a-4848-80e0-1f20e8f74d79")
                        },
                        new
                        {
                            AccountId = new Guid("b29593e8-2942-43c1-bae0-827d11b531fa"),
                            AccountType = "Savings",
                            DateCreated = new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OwnerId = new Guid("84233508-d81b-4905-a559-361b797c2847")
                        },
                        new
                        {
                            AccountId = new Guid("b3e4b433-eec4-4095-80ec-690f94c08c0e"),
                            AccountType = "Savings",
                            DateCreated = new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OwnerId = new Guid("2e11a8a7-ac21-4b9a-854f-57750e2c2091")
                        },
                        new
                        {
                            AccountId = new Guid("865dfdf9-dd70-4d16-ad74-309a5c2140d8"),
                            AccountType = "Current",
                            DateCreated = new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OwnerId = new Guid("8b4f98a4-7d0c-448e-a273-8f0fe04138b7")
                        },
                        new
                        {
                            AccountId = new Guid("f6f067fd-592c-4a33-bcd2-8e48b525cdf0"),
                            AccountType = "Current",
                            DateCreated = new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OwnerId = new Guid("65061353-8db0-4d1c-a561-07bce550739a")
                        });
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
                            OwnerId = new Guid("bef77066-871b-4d1d-a992-b6ecba2437bd"),
                            Address = "Dhaka",
                            DateOfBirth = new DateTime(1987, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Mohammed Salah"
                        },
                        new
                        {
                            OwnerId = new Guid("71e13584-cff9-41ce-ad8e-33a99783a6e5"),
                            Address = "Chittagong",
                            DateOfBirth = new DateTime(1981, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Joshim Shekh"
                        },
                        new
                        {
                            OwnerId = new Guid("ea4bee19-8b99-4375-9c4e-5548541b7258"),
                            Address = "Barishal",
                            DateOfBirth = new DateTime(1985, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "MD Lutfur"
                        },
                        new
                        {
                            OwnerId = new Guid("ab05178e-0a58-410f-83f9-6ec6fc06df6f"),
                            Address = "Dhaka",
                            DateOfBirth = new DateTime(1964, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Tom Hanks"
                        },
                        new
                        {
                            OwnerId = new Guid("ec5e1e39-63c4-4da8-b41e-678f1d2b1a61"),
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
