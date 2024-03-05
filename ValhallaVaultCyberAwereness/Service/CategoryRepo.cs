using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwereness.Data;
using ValhallaVaultCyberAwereness.Data.Models;


namespace ValhallaVaultCyberAwereness.Service
{
    public class CategoryRepo(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context;
        public List<Category> categories { get; set; } = new List<Category>();
        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            categories = await _context.Categories
                .Include(x => x.Segments)
                .ToListAsync();

            return await _context.Categories.
                Include(x => x.Segments).ToListAsync();

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
