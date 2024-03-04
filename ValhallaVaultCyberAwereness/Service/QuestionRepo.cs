using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwereness.Data;
using ValhallaVaultCyberAwereness.Data.Models;


namespace ValhallaVaultCyberAwereness.Service
{
    public class QuestionRepo(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context;

        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            return await _context.Categories.ToListAsync();
        }
        public async Task<Category?> GetCategoryByIdAsync(int id)
        {
            return await _context.Categories.FirstOrDefaultAsync(c => c.CategoryId == id);
        }

        public async Task AddCategoryAsync(Category categoryToAdd)
        {
            await _context.Categories.AddAsync(categoryToAdd);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCategoryAsync(Category updatedCategory)
        {
            Category? categoryToUpdate = await GetCategoryByIdAsync(updatedCategory.CategoryId);

            if (categoryToUpdate == null)
            {
                categoryToUpdate.Categories = updatedCategory.Categories;

                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteCategoryAsync(Category categoryToDelete)
        {
            try
            {
                _context.Categories.Remove(categoryToDelete);
                await _context.SaveChangesAsync();
            }
            catch
            {

            }
        }

    }
}
