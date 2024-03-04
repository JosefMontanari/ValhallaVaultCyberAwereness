using System.ComponentModel.DataAnnotations;

namespace ValhallaVaultCyberAwereness.Data.Models;

public class Answer
{
    [Key]
    public int AnswerId { get; set; }

    public string Answers { get; set; }

    public Question Questions { get; set; }

    public int QuestionId { get; set; } // foreign key

    // Länkas till en user

    public ApplicationUser User { get; set; }

    public Guid UserId { get; set; } // User Id fråm Db

}
