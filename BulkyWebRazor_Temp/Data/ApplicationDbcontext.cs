﻿using BulkyWebRazor_Temp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace BulkyWebRazor_Temp.Data
{
    public class ApplicationDbcontext:DbContext
    {
        
            public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
            {

            }

            public DbSet<Category> Categories { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Category>().HasData(
                    new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                    new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                    new Category { Id = 3, Name = "Mystery", DisplayOrder = 3 });
            }
    }
}

