using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuranHalaqa.Models;

namespace QuranHalaqa.Data
{
    public class HalaqaDB : IdentityDbContext
    {
        public HalaqaDB(DbContextOptions<HalaqaDB> options)
            : base(options)
        {
        }

        public virtual DbSet<QuranJuz> Quranjuz { get; set; }
        public virtual DbSet<Sheikh> Sheikh { get; set; }
        public virtual DbSet<Halaqa> Halaqa { get; set; }
        public virtual DbSet<HalaqaSession> HalaqaSession { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<Exam> Exam { get; set; }
        public virtual DbSet<ExamEntry> ExamEntry { get; set; }
        public virtual DbSet<QuranSura> QuranSura { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentWork> StudentWork { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //1 session for each student.
            modelBuilder.Entity<StudentWork>().HasIndex(SW => new { SW.StudentId, SW.HalaqaSessionId }).IsUnique();
        }
    }
}
