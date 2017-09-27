using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Many_To_Many.Models
{
    public class SchoolDBContext : DbContext
    {




        public SchoolDBContext() : base("SchoolDB-DataAnnotations")
        {
        }

        public DbSet<Stu> Students { get; set; }

        public DbSet<Course> Courses { get; set; }





        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Sau");
            modelBuilder.Entity<Stu>()
                        .HasKey(e => e.StudentId)
                        .HasMany<Course>(s => s.Courses)
                        .WithMany(c => c.Students)
                        .Map(cs =>
                        {
                            cs.MapLeftKey("StudentRefId");
                            cs.MapRightKey("CourseRefId");
                            cs.ToTable("StudentCourse");
                        });



            modelBuilder.Entity<Course>().Property(e => e.CourseName)
             .IsRequired()
             .HasMaxLength(50);


        }

    }
}