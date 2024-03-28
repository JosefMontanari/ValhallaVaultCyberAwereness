using Microsoft.AspNetCore.Mvc;
using ValhallaVaultCyberAwereness.Data.Models;
using ValhallaVaultCyberAwereness.Service;

//Låter denna controller vara, lägg på mer funktioner om behov för API skulle finnas. //Tim 

namespace ValhallaVaultCyberAwereness.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase // api/question/
    {

        public readonly QuestionRepo _questionRepo;

        public QuestionController(QuestionRepo qService)
        {
            _questionRepo = qService;
        }

        [HttpGet]
        public async Task<List<Question>> GetAllQuestions()
        {
            return await _questionRepo.GetAllQuestionAsync();
        }

        // Test
        [HttpPost]
        public async Task<IActionResult> AddNnewQuestion(Question questions)
        {
            if (string.IsNullOrEmpty(questions.Title) || string.IsNullOrEmpty(questions.Questions) || string.IsNullOrEmpty(questions.CorrectAnswer) || questions.PossibleAnswers.Count < 3)
            {
                return BadRequest("Must contain 3 possible answers, title, 1 question and 1 correct answer");
            }
            await _questionRepo.AddQuestionAsync(questions);
            return Ok("Successful POST request");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateQuestion(Question questions)
        {
            await _questionRepo.UpdateQuestionAsync(questions);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteQuestion(Question questions)
        {

            await _questionRepo.DeleteQuestionAsync(questions);
            return Ok();
        }

    }
}
