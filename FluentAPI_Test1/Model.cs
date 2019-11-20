using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EatingApp.Entities;

namespace FluentAPI_Test1
{
    class Model:DbContext
    {
        public DbSet<Student> Students { get; set; }
        

        private const string connectionString = @"server=DESKTOP-3M8H7CG; database=FluentAPItask1DB; Integrated Security=true;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
    }

    public class Student
    {
        public int studentId { get; set; }
        public string studetName { get; set; }
        public string ClassName { get; set; }
    }
}
