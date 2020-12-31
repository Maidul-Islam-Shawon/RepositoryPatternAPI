using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class AccountSeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.InsertData(
                table: "account",
                columns: new[] { "AccountId", "AccountType", "DateCreated", "OwnerId" },
                values: new object[,]
                {
                    { new Guid("10c4f57d-5f70-4d4a-92a0-b8b7cf86ca13"), "Savings", new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8b4f98a4-7d0c-448e-a273-8f0fe04138b7") },
                    { new Guid("7e34c9fa-7c7d-4307-be5e-52cf89e0450a"), "Current", new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65061353-8db0-4d1c-a561-07bce550739a") },
                    { new Guid("a7445a4c-c368-4683-9906-ee32721e37a6"), "Current", new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0acbed4a-922a-4848-80e0-1f20e8f74d79") },
                    { new Guid("b29593e8-2942-43c1-bae0-827d11b531fa"), "Savings", new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("84233508-d81b-4905-a559-361b797c2847") },
                    { new Guid("b3e4b433-eec4-4095-80ec-690f94c08c0e"), "Savings", new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2e11a8a7-ac21-4b9a-854f-57750e2c2091") },
                    { new Guid("865dfdf9-dd70-4d16-ad74-309a5c2140d8"), "Current", new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8b4f98a4-7d0c-448e-a273-8f0fe04138b7") },
                    { new Guid("f6f067fd-592c-4a33-bcd2-8e48b525cdf0"), "Current", new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65061353-8db0-4d1c-a561-07bce550739a") }
                });

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
