using Classes.Models;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Classes.Data {
   public class ApplicationDbContext : IdentityDbContext {
    
      public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options) {
      }


      // Add some 'tables' to DB
      public DbSet<AppUsers> AppUsers { get; set; }
      public DbSet<Students> Students { get; set; }
      public DbSet<Professors> Professors { get; set; }
      public DbSet<CourseUnits> CourseUnits { get; set; }
      public DbSet<Enrollments> Enrollments { get; set; }


   }
}
