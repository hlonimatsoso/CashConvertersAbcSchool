using AbcSchool.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcSchool.Data
{
    public class AbcSchoolDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<StudentSubjects> StudentSubjects { get; set; }


        public AbcSchoolDbContext(DbContextOptions<AbcSchoolDbContext> options)
           : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Set composite PK
            modelBuilder.Entity<StudentSubjects>().HasKey(ss => new { ss.StudentId, ss.SubjectId });

        }

    }
}
