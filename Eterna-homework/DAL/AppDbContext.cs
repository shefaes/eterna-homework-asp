using Eterna_homework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna_homework.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }
        public DbSet<setting> settings { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Portfolioproducts> Portfolioproducts { get; set;}
        public DbSet<Portfolio> Portfolios { get; set; }
    }
}
