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
		public async Task<AnswerUser?> GetUserAnswersByIdAsync(int id)
		{
			return await context.UserAnswers.FirstOrDefaultAsync(u => u.id == id);
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
