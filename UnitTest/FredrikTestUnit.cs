using ValhallaVaultCyberAwereness.Components.Pages.ValhallaPages.QuestionPage;
using ValhallaVaultCyberAwereness.Data.Models;

namespace UnitTest;

public class FredrikTestUnit
{
    AnswerUser answerUser;
    Category category;
    Question question;
    Segment segment; // här finns calculatecorrectanswers metod.
    TicketModel ticket;
    QuestionsPage questionsPage; // StartSegemtn finns här
    List<AnswerUser> userAnswersById;

    public FredrikTestUnit()
    {
        answerUser = new AnswerUser();
        category = new Category();
        question = new Question();
        segment = new Segment();
        ticket = new TicketModel();
        questionsPage = new QuestionsPage();
        userAnswersById = new List<AnswerUser>();

    }

    string userAnswer;
    int userId = 1;
    string userIdd;


    [Fact]
    public void TestCalculateCorrectAnswers()
    {
        // skapa "answers från userId" - Skapa en lista av deras svar
        userAnswersById = new List<AnswerUser>
        {
            // Skapa answr users "svar"
            new AnswerUser {QuestionId = 1, UserAnswer = "2" },
            new AnswerUser {QuestionId = 2, UserAnswer = "1" }

        };

        // gör en lista av questions är "testade"
        segment.Question = new List<Question>
        {
            new Question {QuestionId = 1, CorrectAnswer = "2"},
            new Question {QuestionId = 2, CorrectAnswer = "3"},
            //new Question {QuestionId = 3, CorrectAnswer = "4"}
        };


        double result = segment.CalculateCorrectAnswers(userAnswersById, userIdd);

        Assert.Equal(50, result);

    }


    [Fact]
    public async void TestStartSegment()
    {
        bool canStartOrNot = false;

        var segments = new List<Segment>
        {
            new Segment { SegmentId = 2 },
            new Segment { SegmentId = 3 },
          new Segment { SegmentId = 4 }
        };

        var testaStartSegment = new TestaStartSegment(segments);

        // Testa att starta segment
        await testaStartSegment.StartSegment(2);

        Assert.True(testaStartSegment.canStartOrNot, canStartOrNot.ToString());

        // hehe
    }
}

public class TestaStartSegment
{
    private readonly List<Segment> segments;
    private List<AnswerUser>? userAnswersbyid;
    private string userId;
    public bool canStartOrNot { get; set; }


    public TestaStartSegment(List<Segment> segments)
    {
        this.segments = segments;
    }

    public async Task StartSegment(int segmentId)
    {
        if (segments.Any())
        {
            // låt user starta första segment
            if (segmentId == segments.First().SegmentId)
            {
                canStartOrNot = true;
                return;
                // Sätt en bool til true och ta bort navi i subcategorypage & question page senare för att inte kunna fula
            }

            // kolla om tidigare segement är klar med -1 annars 0 (använd linq)
            var previousSegmentId = segments
                .OrderBy(s => s.SegmentId)
                .FirstOrDefault(s => s.SegmentId >= segmentId - 1)?.SegmentId ?? 0;

            var previousSegment = segments.FirstOrDefault(s => s.SegmentId == previousSegmentId);

            if (previousSegment != null)
            {
                //räkna om prev.Segment till percentCorrect för att låta user gå vidare
                double percentCorrect = previousSegment.CalculateCorrectAnswers(userAnswersbyid, userId);

                if (percentCorrect >= 80)
                {
                    canStartOrNot = true;
                    // Sätt en bool til true och ta bort navi i subcategorypage & question page senare för att inte kunna fula
                }
            }
        }
    }

}

