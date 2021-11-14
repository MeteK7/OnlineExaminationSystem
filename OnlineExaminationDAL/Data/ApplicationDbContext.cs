using Microsoft.EntityFrameworkCore;
using OnlineExaminationDAL.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExaminationDAL.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-TL5BT8Q\\SQLEXPRESS;Database=OnlineExaminationDb;user id=sa;password=mg9R7psU;Trusted_Connection=True;MultipleActiveResultSets=True;");
            }
        }

        public DbSet<ExamResults> ExamResults { get; set; }
        public DbSet<Exams> Exams { get; set; }
        public DbSet<Groups> Groups { get; set; }
        public DbSet<QuestionAnswers> QuestionAnswers { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Name).IsRequired().HasMaxLength(50);
                entity.Property(e => e.UserName).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Password).IsRequired().HasMaxLength(50);
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.Property(e => e.Name).IsRequired().HasMaxLength(50);
                entity.Property(e => e.UserName).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Password).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Contact).HasMaxLength(50);
                entity.Property(e => e.CVFileName).HasMaxLength(250);
                entity.Property(e => e.PictureFileName).HasMaxLength(250);
                entity.HasOne(d => d.Groups).WithMany(p => p.Students).HasForeignKey(d => d.GroupsId);
            });

            modelBuilder.Entity<QuestionAnswers>(entity =>
            {
                entity.Property(e => e.Question).IsRequired();
                entity.Property(e => e.Option1).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Option2).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Option3).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Option4).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Answer).HasMaxLength(250);
                entity.HasOne(d => d.Exams).WithMany(p => p.QnAs).HasForeignKey(d => d.ExamsId).OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Groups>(entity =>
            {
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Description).HasMaxLength(250);
                entity.HasOne(d => d.Users).WithMany(p => p.Groups).HasForeignKey(d => d.UsersId).OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Exams>(entity =>
            {
                entity.Property(e => e.Title).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Description).HasMaxLength(250);
                entity.HasOne(d => d.Groups).WithMany(p => p.Exams).HasForeignKey(d => d.GroupsId).OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ExamResults>(entity =>
            {
                entity.HasOne(d => d.Exams).WithMany(p => p.ExamResults).HasForeignKey(d => d.ExamsId);
                entity.HasOne(d => d.QnAs).WithMany(p => p.ExamResults).HasForeignKey(d => d.QnAsId).OnDelete(DeleteBehavior.ClientSetNull);
                entity.HasOne(d => d.Students).WithMany(p => p.ExamResults).HasForeignKey(d => d.StudentsId).OnDelete(DeleteBehavior.ClientSetNull);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
