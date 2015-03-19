using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations.Schema;

namespace ExamStore.Models
{
    public class StoreContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Category> Categories { get; set; }
        //public DbSet<QuestionMap> QuestionMap { get; set; }
        //public DbSet<ExamMap> ExamMap { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Exam>()
                .HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);




            modelBuilder.Entity<Question>()
                .HasRequired(x=>x.UserCreated)
                .WithMany()
                .WillCascadeOnDelete(false);


        }

        public override int SaveChanges()
        {
            var entities = ChangeTracker.Entries().Where(x=>x.Entity is BaseEntity && (x.State ==EntityState.Added || x.State == EntityState.Modified));
            var currentUserName = HttpContext.Current != null && HttpContext.Current.User != null ? HttpContext.Current.User.Identity.Name : "Anonymous";

            foreach (var entity in entities)
            {
                if (entity.State==EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).DateCreated = DateTime.Now;
                    ((BaseEntity)entity.Entity).DateModified = DateTime.Now;
                    ((BaseEntity)entity.Entity).UserCreatedId = "8525c7e6-a0e7-4f7b-a6b4-51304b09aa33";
                    ((BaseEntity)entity.Entity).UserModifiedId = "8525c7e6-a0e7-4f7b-a6b4-51304b09aa33";

                }
                else
                {
                    if (entity.State==EntityState.Modified)
                    {
                    ((BaseEntity)entity.Entity).DateModified = DateTime.Now;
                    ((BaseEntity)entity.Entity).UserModifiedId = "8525c7e6-a0e7-4f7b-a6b4-51304b09aa33";
                    }
                }
            }
                return base.SaveChanges();
        }
    }
}