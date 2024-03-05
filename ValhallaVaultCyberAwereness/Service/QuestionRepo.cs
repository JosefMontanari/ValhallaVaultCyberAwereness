using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwereness.Data;
using ValhallaVaultCyberAwereness.Data.Models;

namespace ValhallaVaultCyberAwereness.Service
{
    public class QuestionRepo(ApplicationDbContext context)
    {


        public async Task<List<Question>> GetAllQuestionAsync()
        {
            return await context.Questions.ToListAsync();
        }

        public async Task<Question?> GetQuestionByIdAsync(int id)
        {
            return await context.Questions.FirstOrDefaultAsync(q => q.QuestionId == id);
        }
        public async Task AddQuestionAsync(Question questionToAdd)
        {
            await context.Questions.AddAsync(questionToAdd);
            await context.SaveChangesAsync();
        }

        public async Task UpdateQuestionAsync(Question updatedQuestion)
        {
            Question? updateQuestion = await GetQuestionByIdAsync(updatedQuestion.QuestionId);

            if (updateQuestion != null)
            {
                updateQuestion.Questions = updatedQuestion.Questions;

                await context.SaveChangesAsync();
            }
        }
        public async Task DeleteQuestionAsync(Question questionToDelete)
        {
            try
            {
                context.Questions.Remove(questionToDelete);
                await context.SaveChangesAsync();
            }
            catch
            {

            }
        }
    }

}
