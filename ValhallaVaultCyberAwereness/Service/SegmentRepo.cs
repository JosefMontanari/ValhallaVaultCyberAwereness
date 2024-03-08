using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwereness.Data;
using ValhallaVaultCyberAwereness.Data.Models;

namespace ValhallaVaultCyberAwereness.Service
{
    public class SegmentRepo(ApplicationDbContext context)
    {

        public List<Segment> segments { get; set; } = new List<Segment>();

        public async Task<List<Segment>> GetAllSegmentAsync()
        {
            segments = await context.Segments
                .Include(q => q.Question)
                .ToListAsync();

            return await context.Segments
                .Include(q => q.Question)
                .ToListAsync();
        }
        public async Task<Segment?> GetSegmentByIdAsync(int id)
        {
            return await context.Segments.FirstOrDefaultAsync(s => s.SegmentId == id);
        }
        public async Task<List<Segment>> GetSegmentsByCategoryIdAsync(int categoryId)
        {
            return await context.Segments
                .Include(q => q.Question)
                .Where(s => s.CategoryId == categoryId)
                .ToListAsync();
        }
        public async Task AddSegmentAsync(Segment segmentToAdd)
        {
            await context.Segments.AddAsync(segmentToAdd);
            await context.SaveChangesAsync();
        }
        public async Task UpdateSegmentAsync(Segment updatedSegment)
        {
            Segment? SegmentUpdate = await GetSegmentByIdAsync(updatedSegment.SegmentId);

            if (SegmentUpdate != null)
            {

                SegmentUpdate.Category = updatedSegment.Category;

                SegmentUpdate.SegmentTitle = updatedSegment.SegmentTitle;

                await context.SaveChangesAsync();
            }
        }
        public async Task DeleteSegment(Segment segmentToDelete)
        {
            try
            {
                context.Segments.Remove(segmentToDelete);
                await context.SaveChangesAsync();
            }
            catch
            {

            }
        }
    }
}
