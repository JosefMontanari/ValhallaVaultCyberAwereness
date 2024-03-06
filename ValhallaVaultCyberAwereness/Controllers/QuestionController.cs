using Microsoft.AspNetCore.Mvc;
using ValhallaVaultCyberAwereness.Data.Models;
using ValhallaVaultCyberAwereness.Service;

namespace ValhallaVaultCyberAwereness.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
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
    }
}
