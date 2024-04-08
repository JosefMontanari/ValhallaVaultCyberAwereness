using ValhallaVaultCyberAwereness.Data.Models;

namespace UnitTest
{
	public class JosefsTest
	{
		List<AnswerUser> userAnswers;
		AnswerUser answerUser;
		Category category;
		Segment segment;
		string userId = "Josef";

		public JosefsTest()
		{
			userAnswers = new List<AnswerUser>();
			answerUser = new AnswerUser();
			category = new Category();
			segment = new Segment();
		}

		[Fact]
		public async void CalculateAnswers()
		{
			userAnswers = new List<AnswerUser>
			{
				new AnswerUser() {QuestionId = 1, UserAnswer = "Ja"},
				new AnswerUser() {QuestionId = 2, UserAnswer = "Perkele"},
				new AnswerUser() {QuestionId = 3, UserAnswer = "Långt lösenord"},
				new AnswerUser() {QuestionId = 4, UserAnswer = "New phone"}

			};

			segment.Question = new List<Question>
			{
				new Question() {QuestionId = 1, CorrectAnswer = "Ja"},
				new Question() {QuestionId = 2, CorrectAnswer = "Perkele"},
				new Question() {QuestionId = 3, CorrectAnswer = "Långt lösenord"},
				new Question() {QuestionId = 4, CorrectAnswer = "New phone"},
			};

			double result = segment.CalculateCorrectAnswers(userAnswers, userId);

			Assert.True(result == 100);

		}
	}
}
