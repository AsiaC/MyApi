using MyApi.Enums;
using MyApi.Models;

namespace MyApi.Services
{
    public interface IFlashcardService
    {
        Task<List<Flashcard>> GetFlashCardsAsync();
        Task<Flashcard?> GetFlashCardByIdAsync(int id);
        Task<Flashcard> CreateFlashCard(Flashcard flashcard);
        Task<Flashcard> UpdateFlashCard(int id, Flashcard flashcard);
        Task<bool> DeleteFlashCard(int id);        
        Task<List<Flashcard>> GetFlashCardsByRepetition(RepetitionEnum repetitionEnum);
    }
}
