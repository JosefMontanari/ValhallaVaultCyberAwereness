using ValhallaVaultCyberAwereness.Data.Models;

namespace TimsUnitTest
{
    public class TimsTestUnit
    {
        Segment segment = new Segment();

        List<AnswerUser> AnswersFromUser = new List<AnswerUser>();


        public void SetupQuestions()
        {
            segment.Question = new List<Question>
            {
                new Question { QuestionId = 1, CorrectAnswer = "Sol" },
                new Question { QuestionId = 2, CorrectAnswer = "vår" }
            };
        }


        [Fact]
        public void TestCalculateAnswers100()
        {
            SetupQuestions();
            int expected = 100;
            AnswersFromUser = new List<AnswerUser>
            {
                new AnswerUser { QuestionId = 1, UserAnswer = "Sol" },
                new AnswerUser { QuestionId = 2, UserAnswer = "vår" }
            };


            var result = segment.CalculateCorrectAnswers(AnswersFromUser, "1");

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestCalculateAnswers50()
        {
            SetupQuestions();
            int expected = 50;
            AnswersFromUser = new List<AnswerUser>
            {
                new AnswerUser { QuestionId = 1, UserAnswer = "vinter" },
                new AnswerUser { QuestionId = 2, UserAnswer = "vår" }
            };

            var result = segment.CalculateCorrectAnswers(AnswersFromUser, "1");

            Assert.Equal(expected, result);
        }
        [Fact]
        public void TestCalculateAnswersNoRight()
        {
            SetupQuestions();
            int expected = 0;
            AnswersFromUser = new List<AnswerUser>
            {
                new AnswerUser { QuestionId = 1, UserAnswer = "regn" },
                new AnswerUser { QuestionId = 2, UserAnswer = "åskväder" }
            };

            var result = segment.CalculateCorrectAnswers(AnswersFromUser, "1");

            Assert.Equal(expected, result);
        }
    }
}