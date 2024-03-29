﻿using System.ComponentModel.DataAnnotations;

namespace ValhallaVaultCyberAwereness.Data.Models;

public class Segment
{
    [Key]
    public int SegmentId { get; set; }


    [Required(ErrorMessage = "Segment name is required")]
    [MinLength(4, ErrorMessage = "Segment name must be at least 4 characters long")]
    public string SegmentTitle { get; set; }

    public Category? Category { get; set; } // Har en category

    public int? CategoryId { get; set; } // f-key

    public List<Question>? Question { get; set; } = new List<Question>(); // har flera questions 


    // Metod för att räkna ut antal rätt
    public double CalculateCorrectAnswers(List<AnswerUser> userAnswersbyid, string userId)
    {
        // räkna antalet questions
        if (Question == null || Question.Count == 0)
            return 0;

        // gå igenom alla Questions i Segments listan
        int correctCount = 0;
        foreach (var question in Question)
        {
            // kolla efter varje questionId och Userns answer
            var userAnswer = userAnswersbyid.FirstOrDefault(a => a.QuestionId == question.QuestionId)?.UserAnswer;

            // Se om svar är rätt, isåfall ++ 
            if (userAnswer != null && userAnswer.Equals(question.CorrectAnswer, StringComparison.OrdinalIgnoreCase))
            {
                correctCount++;
            }
        }
        return (double)correctCount / Question.Count * 100;
    }
}

