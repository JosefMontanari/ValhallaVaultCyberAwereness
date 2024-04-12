using Microsoft.AspNetCore.Mvc;
using ValhallaVaultCyberAwereness.Data.Models;
using ValhallaVaultCyberAwereness.Service;

namespace ValhallaVaultCyberAwereness.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public readonly CategoryRepo _categpryRepo;

        public CategoryController(CategoryRepo cService)
        {
            _categpryRepo = cService;
        }

        [HttpGet]

        public async Task<List<Category>> GetAllCategories()
        {
            return await _categpryRepo.GetAllCategoriesAsync();
        }

        // Test 
        [HttpPost]

        public async Task<IActionResult> AddNewCategory(Category category)
        {
            if (string.IsNullOrEmpty(category.Categories))
            {
                return BadRequest("Category name cant be empty");
            }
            await _categpryRepo.AddCategoryAsync(category);
            return Ok("Successful POST request");
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(int id, Category category)
        {
            var existingCategory = await _categpryRepo.GetCategoryByIdAsync(id);
            if (existingCategory == null)
            {
                return NotFound("Category not found");
            }

            existingCategory.Categories = category.Categories; // Update other properties as needed
            await _categpryRepo.UpdateCategoryAsync(existingCategory);
            return Ok("Category updated successfully");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var existingCategory = await _categpryRepo.GetCategoryByIdAsync(id);
            if (existingCategory == null)
            {
                return NotFound("Category not found");
            }

            await _categpryRepo.DeleteCategoryAsync(existingCategory);
            return Ok("Category deleted successfully");
        }


    }

}

