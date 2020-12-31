using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.SeedData
{
    public class OwnerSeedData : IEntityTypeConfiguration<Owner>
    {
        public void Configure(EntityTypeBuilder<Owner> builder)
        {
            builder.HasData(
                    new Owner
                    {
                        OwnerId = Guid.NewGuid(),
                        Name = "Mohammed Salah",
                        Address = "Dhaka",
                        DateOfBirth = new DateTime(1987, 10, 11)
                    },
                    new Owner
                    {
                        OwnerId = Guid.NewGuid(),
                        Name = "Joshim Shekh",
                        Address = "Chittagong",
                        DateOfBirth = new DateTime(1981, 10, 01)
                    },
                    new Owner
                    {
                        OwnerId = Guid.NewGuid(),
                        Name = "MD Lutfur",
                        Address = "Barishal",
                        DateOfBirth = new DateTime(1985, 07, 25)
                    },
                     new Owner
                     {
                         OwnerId = Guid.NewGuid(),
                         Name = "Tom Hanks",
                         Address = "Dhaka",
                         DateOfBirth = new DateTime(1964, 02, 02)
                     },
                      new Owner
                      {
                          OwnerId = Guid.NewGuid(),
                          Name = "MD Lutfur",
                          Address = "Barishal",
                          DateOfBirth = new DateTime(1990, 08, 11)
                      }
                );
        }
    }
}
