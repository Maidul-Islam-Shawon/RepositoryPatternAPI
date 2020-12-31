﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.SeedData
{
    public static class SeedMigrationManager
    {

        public static IHost MigrateDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                using(var appContext = scope.ServiceProvider.GetRequiredService<RepositoryContext>())
                {
                    try
                    {
                        appContext.Database.Migrate();
                    }
                    catch(Exception ex)
                    {
                        throw;
                    }
                }
            }
            return host;
        }
    }
}
