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

			}
		}
	}
}
