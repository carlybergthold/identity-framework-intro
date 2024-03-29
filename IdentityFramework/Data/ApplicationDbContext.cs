﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using IdentityFramework.Models;

namespace IdentityFramework.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

            public DbSet<ApplicationUser> ApplicationUsers { get; set; }

            public DbSet<IdentityFramework.Models.Product> Product { get; set; }
    }
}
