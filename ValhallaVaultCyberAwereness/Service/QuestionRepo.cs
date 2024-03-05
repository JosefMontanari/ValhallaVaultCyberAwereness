using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwereness.Data;
using ValhallaVaultCyberAwereness.Data.Models;

namespace ValhallaVaultCyberAwereness.Service
{
    public class QuestionRepo(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context;

        public async Task<List<Question>> GetAllQuestionAsync()
        {
            return await _context.Questions.ToListAsync();
        }

        public async Task<Question?> GetQuestionByIdAsync(int id)
        {
            return await _context.Questions.FirstOrDefaultAsync(q => q.QuestionId == id);
        }
        public async Task AddQuestionAsync(Question questionToAdd)
        {
            await _context.Questions.AddAsync(questionToAdd);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateQuestionAsync(Question updatedQuestion)
        {
            Question? updateQuestion = await GetQuestionByIdAsync(updatedQuestion.QuestionId);

            if (updateQuestion != null)
            {
                updateQuestion.Questions = updatedQuestion.Questions;

                await _context.SaveChangesAsync();
            }
        }
        public async Task DeleteQuestionAsync(Question questionToDelete)
        {
            try
            {
                _context.Questions.Remove(questionToDelete);
                await _context.SaveChangesAsync();
            }
            catch
            {

            }
        }
    }

}
