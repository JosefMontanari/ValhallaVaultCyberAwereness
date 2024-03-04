namespace ValhallaVaultCyberAwereness.wwwroot.JSONData;

public class AnnaData
{
    // Dummydata


}

public class Categories
{
    public List<Question> QuestionData { get; set; } = new List<Question>
        {
            new Question
            {
                QuestionId = 1,
                Questions = "Penetration tester - what does he/she do?",
                PossibleAnswers = new List<string> { "hacking people", "testing code", "eating ass" },
                CorrectAnswer = "testing code",
                SegmentId = 1  // segment 1
            },
            new Question
            {
                QuestionId = 2,
                Questions = "What is red team doing??",
                PossibleAnswers = new List<string> { "Cyberattacker", "Cyberdefender", "Penetratiing ass" },
                CorrectAnswer = "Cyberattacker",
                SegmentId = 2 // segmnt 2
            },
            new Question
            {
                QuestionId = 3,
                Questions = "What is blue team doing?",
                PossibleAnswers = new List<string> { "Defending cyberattacks", "Attacking coders", "codeattacking mup" },
                CorrectAnswer = "Defending cyberattacks",
                SegmentId = 3 // tillhör segment 3
            }

        };

}

public class Segments
{
    public List<Segment> SegmentData { get; set; } = new List<Segment>
        {
            new Segment
            {
                SegmentId = 1,
                SegmentTitle = "Penetration lover",
                CategoryId = 1 // tillhör categori 1
            },
            new Segment
            {
                SegmentId = 2,
                SegmentTitle = "Ass-Penetration king ",
                CategoryId = 1 // categori 1
            },
            new Segment
            {
                SegmentId = 3,
                SegmentTitle = "Penetratiion defender",
                CategoryId = 2 // tillhör categori 2
            }

        };

}

public class Questions
{

    public List<Category> CategoryData { get; set; } = new List<Category>
        {
            new Category
            {
                CategoryId = 1,
                Categories = "Red team"
            },
            new Category
            {
                CategoryId = 2,
                Categories = "Blue team"
            }

        };

}