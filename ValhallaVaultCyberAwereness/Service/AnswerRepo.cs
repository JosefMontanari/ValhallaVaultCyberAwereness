using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwereness.Data;
using ValhallaVaultCyberAwereness.Data.Models;

namespace ValhallaVaultCyberAwereness.Service
{
    public class AnswerRepo(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context;

        public async Task<List<AnswerUser>> GetAllAnswersAsync()
        {
            return await _context.UserAnswers.ToListAsync();
        }
        public async Task<AnswerUser?> GetUserAnswersByIdAsync(int id)
        {
            return await _context.UserAnswers.FirstOrDefaultAsync(u => u.UserAnswersId == id);
        }

        public async Task AddUserAnswersAsync(AnswerUser userAnswersToAdd)
        {
            await _context.UserAnswers.AddAsync(userAnswersToAdd);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateUserAnswersAsync(AnswerUser userAnswersToUpdate)
        {
            AnswerUser? userAnswersUpdate = await GetUserAnswersByIdAsync(userAnswersToUpdate UserAnswerId);

            if (userAnswersToUpdate != null)
            {
                userAnswersToUpdate.UserAnswers = userAnswersToUpdate.UserAnswers;

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
