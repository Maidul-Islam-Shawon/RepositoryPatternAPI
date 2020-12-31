using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.SeedData
{
    public class AccountSeedData : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasData(
                new Account
                {
                    AccountId = Guid.NewGuid(),
                    AccountType = "Savings",
                    DateCreated = new DateTime(2020, 11, 20),
                    OwnerId = new Guid("8b4f98a4-7d0c-448e-a273-8f0fe04138b7")
                },
                new Account
                {
                    AccountId = Guid.NewGuid(),
                    AccountType = "Current",
                    DateCreated = new DateTime(2018, 12, 15),
                    OwnerId = new Guid("65061353-8db0-4d1c-a561-07bce550739a")
                },
                new Account
                {
                    AccountId = Guid.NewGuid(),
                    AccountType = "Current",
                    DateCreated = new DateTime(2018, 12, 15),
                    OwnerId = new Guid("0acbed4a-922a-4848-80e0-1f20e8f74d79")
                },
                new Account
                {
                    AccountId = Guid.NewGuid(),
                    AccountType = "Savings",
                    DateCreated = new DateTime(2020, 11, 20),
                    OwnerId = new Guid("84233508-d81b-4905-a559-361b797c2847")
                },
                new Account
                {
                    AccountId = Guid.NewGuid(),
                    AccountType = "Savings",
                    DateCreated = new DateTime(2020, 11, 20),
                    OwnerId = new Guid("2e11a8a7-ac21-4b9a-854f-57750e2c2091")
                },
                new Account
                {
                    AccountId = Guid.NewGuid(),
                    AccountType = "Current",
                    DateCreated = new DateTime(2018, 12, 15),
                    OwnerId = new Guid("8b4f98a4-7d0c-448e-a273-8f0fe04138b7")
                },
                new Account
                {
                    AccountId = Guid.NewGuid(),
                    AccountType = "Current",
                    DateCreated = new DateTime(2020, 11, 20),
                    OwnerId = new Guid("65061353-8db0-4d1c-a561-07bce550739a")
                }
                );
        }
    }
}
