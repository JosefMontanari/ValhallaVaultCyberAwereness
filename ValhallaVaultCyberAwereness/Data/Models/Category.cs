using System.ComponentModel.DataAnnotations;

namespace ValhallaVaultCyberAwereness.Data.Models;

public class Category
{
	[Key]
	public int CategoryId { get; set; }

	[Required(ErrorMessage = "Category name is required")]
	[MinLength(6, ErrorMessage = "Category name must be at least 6 characters long")]
	public string Categories { get; set; }

	public List<Segment>? Segments { get; set; } = new List<Segment>(); // har flera segment

    //public int SegmentId { get; set; } // F-key 



}
