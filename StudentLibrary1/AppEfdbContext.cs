using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StudentLibrary1
{
    public partial class AppEfdbContext : DbContext
    {
        public AppEfdbContext()
        {
        }

        public AppEfdbContext(DbContextOptions<AppEfdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Majors> Majors { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<Students> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=localhost\\sqlexpress;database=AppEfdb;trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Courses>(entity =>
            {
                entity.ToTable("courses");

                entity.HasIndex(e => e.MajorId);

                entity.Property(e => e.Instructor).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Major)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.MajorId);
            });

            modelBuilder.Entity<Majors>(entity =>
            {
                entity.ToTable("majors");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.ToTable("schedule");

                entity.HasIndex(e => e.MajorId);

                entity.HasOne(d => d.Major)
                    .WithMany(p => p.Schedule)
                    .HasForeignKey(d => d.MajorId);
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.ToTable("students");

                entity.HasIndex(e => e.MajorId);

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Gpa).HasColumnName("GPA");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Sat).HasColumnName("SAT");

                entity.HasOne(d => d.Major)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.MajorId);
            });
        }
    }
}
