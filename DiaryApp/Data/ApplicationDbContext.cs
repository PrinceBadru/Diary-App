using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DiaryApp.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry { 
                    Id=1, Title="Went Hiking" ,
                    Description= "Went Hiking with Joey",
                    Created = new DateTime(2025, 5, 1, 12, 0, 0) // ✅ Use a fixed datetime
                },
                new DiaryEntry
                {
                    Id = 2,
                    Title = "Went Shopping",
                    Description = "Went Shopping with Joey",
                    Created = new DateTime(2025, 5, 1, 12, 0, 0) // ✅ Use a fixed datetime

                },
                new DiaryEntry
                {
                    Id = 3,
                    Title = "Went Balling",
                    Description = "Went Balling with Joey",
                    Created = new DateTime(2025, 5, 1, 12, 0, 0)
                }

                );
        }
        //Four Steps to add a table
        //1.Create a model class
        //2.Add Db Set
        //3.Add-migration AddDiaryEntryTable
        //4.Update-database

    }
}
