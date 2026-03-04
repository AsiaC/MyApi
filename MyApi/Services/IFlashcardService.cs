using MyApi.Dtos;
using MyApi.Enums;
using MyApi.Models;

namespace MyApi.Services
{
    public interface IFlashcardService
    {
        Task<List<FlashcardResponse>> GetFlashCardsAsync();
        Task<FlashcardResponse?> GetFlashCardByIdAsync(int id);
        Task<Flashcard> CreateFlashCard(Flashcard flashcard);
        Task<Flashcard> UpdateFlashCard(int id, Flashcard flashcard);
        Task<bool> DeleteFlashCard(int id);        
        Task<List<FlashcardResponse>> GetFlashCardsByRepetition(RepetitionEnum repetitionEnum);
    }
}
