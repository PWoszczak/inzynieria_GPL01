﻿using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LAB.Authorization.Roles;
using LAB.Authorization.Users;
using LAB.MultiTenancy;
using LAB.Cars;
using LAB.Flowers;
using LAB.Bouquets;

namespace LAB.EntityFrameworkCore
{
    public class LABDbContext : AbpZeroDbContext<Tenant, Role, User, LABDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<Flower> Flowers { get; set; }

        public DbSet<Bouquet> Bouquets { get; set; }

        public DbSet<Car> Cars { get; set; }
        public LABDbContext(DbContextOptions<LABDbContext> options)
            : base(options)
        {
        }
    }
}
