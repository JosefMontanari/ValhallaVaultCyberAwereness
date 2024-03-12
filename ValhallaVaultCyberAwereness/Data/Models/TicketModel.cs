using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ValhallaVaultCyberAwereness.Data.Models
{
	public class TicketModel
	{
		[Key]
		public int TicketId { get; set; }
		[NotMapped]
		public List<string> ProblemAreas { get; set; } = new List<string>() { "Categories", "Segments", "Questions", "Account", "Login", "Other" };

		[Required(ErrorMessage = "Choose which part of the app you are having issues with")]
		public string ProblemArea { get; set; } = null!;
		public DateTime TimeSubmitted { get; set; }

		[Required(ErrorMessage = "You must describe your problem in order for us to help you")]
		[MinLength(40, ErrorMessage = "Describtion must be at least 40 characters long")]
		public string ProblemDescription { get; set; } = null!;

		[Required(ErrorMessage = "Please provide an email in order for us to get back to you")]
		[EmailAddress(ErrorMessage = "Input must be an email address")]
		public string EmailAdress { get; set; } = null!;
		public ApplicationUser? SubmittedByUser { get; set; }
	}
}
