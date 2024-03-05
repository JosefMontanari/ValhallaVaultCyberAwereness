using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwereness.Data;
using ValhallaVaultCyberAwereness.Data.Models;

namespace ValhallaVaultCyberAwereness.Service
{
    public class AnswerRepo(ApplicationDbContext context)
    {
        private readonly QuestionRepo questionRepo;

        private readonly ApplicationDbContext _context;


        public async Task<List<AnswerUser>> GetAllAnswersAsync()
        {

            return await _context.UserAnswers.ToListAsync();
        }
        public async Task<AnswerUser?> GetUserAnswersByIdAsync(int id)
        {
            return await _context.UserAnswers.FirstOrDefaultAsync(u => u.id == id);
        }

        public async Task AddUserAnswersAsync(AnswerUser userAnswersToAdd)
        {
            await _context.UserAnswers.AddAsync(userAnswersToAdd);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUserAnswersAsync(Question oldAnswer)
        {
            Question? userAnswersToUpdate = await questionRepo.GetQuestionByIdAsync(oldAnswer.QuestionId);

            if (userAnswersToUpdate != null)
            {
                userAnswersToUpdate.CorrectAnswer = oldAnswer.CorrectAnswer;

                await _context.SaveChangesAsync();
            }
        }
        public async Task DeleteUserAnswersAsync(AnswerUser userAnswersToDelete)
        {
            try
            {
                _context.UserAnswers.Remove(userAnswersToDelete);
                await _context.SaveChangesAsync();
            }
            catch
            {

            }
        }
    }
}
