using System.ComponentModel.DataAnnotations;

namespace ValhallaVaultCyberAwereness.Data.Models;

public class Question
{

    [Key]
    public int QuestionId { get; set; }

    public string Questions { get; set; }

    public List<Answer> Answers { get; set; } = new List<Answer>();// flera answers

    public Segment Segment { get; set; } // har en segment

    public int SegmentId { get; set; }
}
