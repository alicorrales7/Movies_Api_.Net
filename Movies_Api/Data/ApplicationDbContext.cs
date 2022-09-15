using System;
using Microsoft.EntityFrameworkCore;
using Movies_Api.Models;

namespace Movies_Api.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet <Client> Clients { get; set; }
    }
}

 