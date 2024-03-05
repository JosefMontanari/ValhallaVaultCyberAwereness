using Microsoft.AspNetCore.Mvc;
using ValhallaVaultCyberAwereness.Data;

namespace ValhallaVaultCyberAwereness.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AnswerController : ControllerBase
    {
        //spara alla användares svar


        private readonly ApplicationDbContext _context;

        public AnswerController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> PostAnswer(List<object> answersFromUser) //kanske ändra object till QuestionModel? men jag tänkte att questionmodel har redan andra properties på sig så kanske lika bra att sända in ett nytt objekt?
        {
            //i listan av objekt lägga in alla svar från UI formuläret, typ questionId? svaret. sedan hämta  userID från blazor (googla om vart man hittar id)..
            return Ok(); //la in return Ok sålänge. 
        }
    }
}
