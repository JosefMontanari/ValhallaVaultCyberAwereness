using ValhallaVaultCyberAwereness.Data.Models;


namespace ValhallaVaultCyberAwereness.Service
{
    public class QuestionRepo(AppDbContext context)
    {
        private readonly AppDbContext _context;

        public QuestionRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            return await _context.Questions.ToListAsync();
        }
        public async Task<Category?> GetCategoryByIdAsync(int id)
        {
            return await _context.Categories.FirstOrDefualtAsync(c => c.Id == id);
        }

        public async Task AddCategoryAsync(Category categoryToAdd)
        {
            await _context.Categories.AddAsync(categoryToAdd);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCategoryAsync(Category updatedCategory)
        {
            Category? categoryToUpdate = await GetCategoryByIdAsync(updatedCategory.Id);

            if (categoryToUpdate == null)
            {
                categoryToUpdate.Name = updatedCategory.Name;

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
