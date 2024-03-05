using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwereness.Data;
using ValhallaVaultCyberAwereness.Data.Models;

namespace ValhallaVaultCyberAwereness.Service
{
    public class AnswerRepo(ApplicationDbContext context)
    {
        private readonly QuestionRepo questionRepo;

        private readonly ApplicationDbContext context;

        public async Task<List<AnswerUser>> GetAllAnswersAsync()
        {

            return await context.UserAnswers.ToListAsync();
        }
        public async Task<AnswerUser?> GetUserAnswersByIdAsync(int id)
        {
            return await context.UserAnswers.FirstOrDefaultAsync(u => u.id == id);
        }

        public async Task AddUserAnswersAsync(AnswerUser userAnswersToAdd)
        {
            await context.UserAnswers.AddAsync(userAnswersToAdd);
            await context.SaveChangesAsync();
        }

        public async Task UpdateUserAnswersAsync(Question oldAnswer)
        {
            Question? userAnswersToUpdate = await questionRepo.GetQuestionByIdAsync(oldAnswer.QuestionId);

            if (userAnswersToUpdate != null)
            {
                userAnswersToUpdate.CorrectAnswer = oldAnswer.CorrectAnswer;

                await context.SaveChangesAsync();
            }
        }
        public async Task DeleteUserAnswersAsync(AnswerUser userAnswersToDelete)
        {
            try
            {
                context.UserAnswers.Remove(userAnswersToDelete);
                await context.SaveChangesAsync();
            }
            catch
            {

            }
        }
    }
}
