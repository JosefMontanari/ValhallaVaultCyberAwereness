using System.ComponentModel.DataAnnotations;

namespace ValhallaVaultCyberAwereness.Data.Models;

public class Question
{

    [Key]
    public int QuestionId { get; set; }

    [Required(ErrorMessage = "Question title is required")]
    [MinLength(4, ErrorMessage = "Title must be at least 4 characters long")]
    public string Title { get; set; } = null!;
    public string? Explanation { get; set; }
    public string? Questions { get; set; }

    public List<string>? PossibleAnswers { get; set; }

    public string? CorrectAnswer { get; set; }

    // public bool IsCorrect {get; set;} <- Ta denna senare när allt displayas osv.

    public Segment? Segment { get; set; } // har en segment

    public int? SegmentId { get; set; }



}