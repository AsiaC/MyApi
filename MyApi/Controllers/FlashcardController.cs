using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApi.Dtos;
using MyApi.Enums;
using MyApi.Models;
using MyApi.Services;

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlashcardController(IFlashcardService flashcardService) : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<FlashcardResponse>>> GetFlashCards()
            => Ok(await flashcardService.GetFlashCardsAsync());

        [HttpGet("{id}")]
        public async Task<ActionResult<FlashcardResponse>> GetFlashCardById(int id)
        {
            var flashcard = await flashcardService.GetFlashCardByIdAsync(id);
            return flashcard == null ? NotFound("Flashcard with the given Id was not found.") : Ok(flashcard);
        }
    }
}
