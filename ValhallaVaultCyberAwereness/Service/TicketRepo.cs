using ValhallaVaultCyberAwereness.Data;
using ValhallaVaultCyberAwereness.Data.Models;

namespace ValhallaVaultCyberAwereness.Service
{
	public class TicketRepo(ApplicationDbContext context)
	{

		public async Task AddTicketAsync(TicketModel ticket)
		{
			await context.UserTickets.AddAsync(ticket);
			await context.SaveChangesAsync();
		}
	}
}
