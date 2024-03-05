using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwereness.Data.Models;

namespace ValhallaVaultCyberAwereness.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {


        public DbSet<Question> Questions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Segment> Segments { get; set; }
        public DbSet<AnswerUser> UserAnswers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Question>()
               .HasData(
               new Question()
               {
                   QuestionId = 1,
                   Questions = "Whats the weather today?",
                   PossibleAnswers = new List<string> { "Rainy", "Sunny", "Wet" },
                   CorrectAnswer = "Sunny",
                   Segment = null,
                   SegmentId = null,
               });
        }
    }
}