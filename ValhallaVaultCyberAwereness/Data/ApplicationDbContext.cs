using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwereness.Data.Models;

namespace ValhallaVaultCyberAwereness.Data
{
	public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
	{
		public DbSet<Question> Questions { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Segment> Segments { get; set; }
	}
}
