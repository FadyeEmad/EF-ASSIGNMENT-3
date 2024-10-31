using EF_SESSION_1_ASSIGNMENT.entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EF_SESSION_1_ASSIGNMENT.context
{
    internal class ITI2Dbcontext : DbContext

    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course_inst>().HasKey(c => new { c.Coure_id, c.inst_id });
            modelBuilder.Entity<Stud_course>().HasKey(c => new { c.Course_id, c.stud_id });
           modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());   

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = . ; database=ITI2; trusted_connection = true;");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Stud_course> stud_Courses { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Topic> topic { get; set; }
       public DbSet<Course_inst> Course_inst {  get; set; }

    }
}
