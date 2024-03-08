using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwereness.Data;
using ValhallaVaultCyberAwereness.Data.Models;

namespace ValhallaVaultCyberAwereness.Service
{

    public class QuestionRepo(ApplicationDbContext context)
    {
        public List<Question> questions { get; set; } = new List<Question>();

        public async Task<List<Question>> GetAllQuestionAsync()
        {
            questions = await context.Questions
                .Include(x => x.Segment)
                .ThenInclude(c => c.Category)
                .ToListAsync();

            return await context.Questions.
                Include(x => x.Segment).
                ThenInclude(c => c.Category).ToListAsync();
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
            Question? QuestionUpdate = await GetQuestionByIdAsync(updatedQuestion.QuestionId);

            if (QuestionUpdate != null)
            {
                QuestionUpdate.Questions = updatedQuestion.Questions;
                QuestionUpdate.Title = updatedQuestion.Title;
                QuestionUpdate.PossibleAnswers = updatedQuestion.PossibleAnswers;
                QuestionUpdate.CorrectAnswer = updatedQuestion.CorrectAnswer;
                QuestionUpdate.Segment = updatedQuestion.Segment;

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
