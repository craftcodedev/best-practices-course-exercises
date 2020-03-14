using System;
using CraftCodeApp.src.Domain.UserAggregate;
using CraftCodeApp.src.Domain.TokenAggregate;
using CraftCodeApp.src.Domain.CourseAggregate;
using CraftCodeApp.src.Infrastructure.Persistence.Mapping;
using Microsoft.EntityFrameworkCore;

namespace CraftCodeApp.src.Shared.Infrastructure.Persistence.Context
{
    public class CraftCodeContext : DbContext
    {

        public CraftCodeContext(DbContextOptions opt) : base(opt) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Token> Tokens { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lesson> Lessons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new TokenMap());
            modelBuilder.ApplyConfiguration(new CourseMap());
            modelBuilder.ApplyConfiguration(new LessonMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
