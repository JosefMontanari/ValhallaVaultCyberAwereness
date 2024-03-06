using Microsoft.AspNetCore.Components;

namespace ValhallaVaultCyberAwereness.Data.Models
{
    public class AnswerUser
    {
        [Parameter]
        public int id { get; set; }
        public ApplicationUser? User { get; set; }
        public int QuestionId { get; set; }
        public Question? Question { get; set; }
        public bool IsAnswerCorrect { get; set; }

        // Behöver spara en users svar i denna klass
        public string? UserAnswer { get; set; }

    }
}
