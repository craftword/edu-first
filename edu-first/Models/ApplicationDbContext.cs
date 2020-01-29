using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace edu_first.Models
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.Migrate();

        }

        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<Score> Scores { get; set; }
        public virtual DbSet<News> NewsDetails { get; set; }
        public virtual DbSet<Gallery> Galleries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Seed();
        }
    } 

   
}
