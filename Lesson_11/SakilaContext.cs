using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Lesson_11
{
    class SakilaContext : DbContext
    {
        public DbSet<Actor> Actor { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\sqlexpress;Database=sakila;Trusted_Connection=True;");
        }
    }
}


