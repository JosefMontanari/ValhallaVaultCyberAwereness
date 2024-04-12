using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwereness.Data;
using ValhallaVaultCyberAwereness.Data.Models;
using ValhallaVaultCyberAwereness.Service;

public class HusamTest
{
    // Testmetod för att hämta alla frågor
    [Fact]
    public async void GetAllQuestionAsync_ReturnQuestion()
    {
        // Förbered inställningar för en in-memory databas
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        // Använd in-memory databasen
        using (var context = new ApplicationDbContext(options))
        {
            // Skapa en ny instans av QuestionRepo med databasen
            var questionRepo = new QuestionRepo(context);

            // Lägg till två frågor i databasen
            context.Questions.AddRange(new List<Question>
            {
                new Question { QuestionId = 1, Title = "Fråga 1" },
                new Question { QuestionId = 2, Title = "Fråga 2" }
            });

            // Spara ändringarna i databasen
            await context.SaveChangesAsync();

            // Anropa GetAllQuestionAsync för att hämta alla frågor
            var result = await questionRepo.GetAllQuestionAsync();

            // Kontrollera att antalet frågor som returnerats är 2
            Assert.Equal(2, result.Count);
        }
    }
}

