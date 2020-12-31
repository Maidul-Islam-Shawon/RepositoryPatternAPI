using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class OwnerSeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "OwnerId", "Address", "DateOfBirth", "Name" },
                values: new object[,]
                {
                    { new Guid("8b4f98a4-7d0c-448e-a273-8f0fe04138b7"), "Dhaka", new DateTime(1987, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mohammed Salah" },
                    { new Guid("65061353-8db0-4d1c-a561-07bce550739a"), "Chittagong", new DateTime(1981, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joshim Shekh" },
                    { new Guid("0acbed4a-922a-4848-80e0-1f20e8f74d79"), "Barishal", new DateTime(1985, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "MD Lutfur" },
                    { new Guid("84233508-d81b-4905-a559-361b797c2847"), "Dhaka", new DateTime(1964, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tom Hanks" },
                    { new Guid("2e11a8a7-ac21-4b9a-854f-57750e2c2091"), "Barishal", new DateTime(1990, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "MD Lutfur" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
