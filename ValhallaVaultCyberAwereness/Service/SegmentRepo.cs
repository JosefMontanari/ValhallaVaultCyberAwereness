using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwereness.Data;
using ValhallaVaultCyberAwereness.Data.Models;

namespace ValhallaVaultCyberAwereness.Service
{
	public class SegmentRepo(ApplicationDbContext context)
	{
		public async Task<List<Segment>> GetAllSegmentAsync()
		{
			return await context.Segments.ToListAsync();
		}
		public async Task<Segment?> GetSegmentByIdAsync(int id)
		{
			return await context.Segments.FirstOrDefaultAsync(s => s.SegmentId == id);
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
				SegmentUpdate.SegmentTitle = updatedSegment.SegmentTitle;
				await context.SaveChangesAsync();
			}
		}
		public async Task DeleteSegmentAsync(Segment segmentToDelete)
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
