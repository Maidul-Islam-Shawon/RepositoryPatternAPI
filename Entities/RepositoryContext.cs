using Entities.Models;
using Entities.SeedData;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Account> Accounts { get; set; }
    
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new OwnerSeedData());
            builder.ApplyConfiguration(new AccountSeedData());
        }
    
    }
}
