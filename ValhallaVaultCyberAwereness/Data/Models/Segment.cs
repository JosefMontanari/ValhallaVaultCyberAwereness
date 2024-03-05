using System.ComponentModel.DataAnnotations;

namespace ValhallaVaultCyberAwereness.Data.Models;

public class Segment
{
    [Key]
    public int SegmentId { get; set; }
    public string SegmentTitle { get; set; }

    public Category Category { get; set; } // Har en category

    public int CategoryId { get; set; } // f-key

    public List<Question> Question { get; set; } = new List<Question>(); // har flera questions

}
