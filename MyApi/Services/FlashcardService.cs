using Microsoft.EntityFrameworkCore;
using MyApi.Data;
using MyApi.Dtos;
using MyApi.Enums;
using MyApi.Models;

namespace MyApi.Services
{
    public class FlashcardService(AppDbContext context) : IFlashcardService
    {        
        public Task<Flashcard> CreateFlashCard(Flashcard flashcard)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteFlashCard(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<FlashcardResponse?> GetFlashCardByIdAsync(int id)
        {
            var result = await context.Flashcards
                .Where(f=>f.Id == id)
                .Select(f => new FlashcardResponse
                {
                    Polish = f.Polish,
                    English = f.English
                }).FirstOrDefaultAsync();

            return result;
        }

        public async Task<List<FlashcardResponse>> GetFlashCardsAsync()
            => await context.Flashcards.Select(f => new FlashcardResponse
            {
                Polish = f.Polish,
                English = f.English
            }).ToListAsync();

        public Task<List<FlashcardResponse>> GetFlashCardsByRepetition(RepetitionEnum repetitionEnum)
        {
            throw new NotImplementedException();
        }

        public Task<Flashcard> UpdateFlashCard(int id, Flashcard flashcard)
        {
            throw new NotImplementedException();
        }
    }
}
