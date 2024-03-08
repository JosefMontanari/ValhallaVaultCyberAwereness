using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwereness.Data;
using ValhallaVaultCyberAwereness.Data.Models;

namespace ValhallaVaultCyberAwereness.Service
{
    public class AnswerRepo(ApplicationDbContext context)
    {
        private readonly QuestionRepo questionRepo;

        public List<AnswerUser> answers { get; set; } = new List<AnswerUser>();

        public async Task<List<AnswerUser>> GetAllAnswersAsync()
        {
            answers = await context.UserAnswers
               .Include(q => q.Question)
               .ToListAsync();

            return await context.UserAnswers.
                Include(q => q.Question).ToListAsync();
        }

        public async Task<List<AnswerUser>>? GetUserAnswersByIdAsync(string userid)
        {
            return await context.UserAnswers.Where(u => u.User.Id == userid).ToListAsync();
        }

        public async Task AddUserAnswersAsync(AnswerUser userAnswersToAdd)
        {
            await context.UserAnswers.AddAsync(userAnswersToAdd);
            await context.SaveChangesAsync();
        }

        public async Task UpdateUserAnswersAsync(AnswerUser oldAnswer)
        {
            AnswerUser? userAnswersToUpdate = await GetUserAnswerAsync(oldAnswer.User.Id, oldAnswer.QuestionId);

            if (userAnswersToUpdate != null)
            {
                userAnswersToUpdate.UserAnswer = oldAnswer.UserAnswer;
                userAnswersToUpdate.IsAnswerCorrect = oldAnswer.IsAnswerCorrect;

                await context.SaveChangesAsync();
            }
        }
        public async Task<AnswerUser?> GetUserAnswerAsync(string userId, int questionId)
        {
            return await context.UserAnswers.FirstOrDefaultAsync(a => a.User.Id == userId && a.QuestionId == questionId);
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
