using System.ComponentModel.DataAnnotations;

namespace ValhallaVaultCyberAwereness.Data.Models;

public class Category
{
	[Key]
	public int CategoryId { get; set; }

	public string Categories { get; set; }

	public List<Segment>? Segments { get; set; } = new List<Segment>(); // har flera segment

	//public int SegmentId { get; set; } // F-key 
}
