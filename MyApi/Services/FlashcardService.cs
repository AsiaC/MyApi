using MyApi.Enums;
using MyApi.Models;

namespace MyApi.Services
{
    public class FlashcardService : IFlashcardService
    {
        static List<Flashcard> flashcards = new List<Flashcard>
        {
            new() {
                Id = 1,
                Polish = "zmartwienie",
                English = "concern",
                IsCompleted = false,
                LastTouch = null,
                Repetition = RepetitionEnum.None,
                WasLastTouchSuccessful = false
            },
            new() {
                Id = 2,
                Polish = "dostarczac",
                English = "provide",
                IsCompleted = false,
                LastTouch = null,
                Repetition = RepetitionEnum.None,
                WasLastTouchSuccessful = false
            },
            new() {
                Id = 3,
                Polish = "rozwiązac",
                English = "sort out",
                IsCompleted = false,
                LastTouch = null,
                Repetition = RepetitionEnum.None,
                WasLastTouchSuccessful = false }
        };
        public Task<Flashcard> CreateFlashCard(Flashcard flashcard)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteFlashCard(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Flashcard?> GetFlashCardByIdAsync(int id)
        {
            var result = flashcards.FirstOrDefault(x => x.Id == id);
            return await Task.FromResult(result);
        }

        public async Task<List<Flashcard>> GetFlashCardsAsync()
            => await Task.FromResult(flashcards);

        public Task<List<Flashcard>> GetFlashCardsByRepetition(RepetitionEnum repetitionEnum)
        {
            throw new NotImplementedException();
        }

        public Task<Flashcard> UpdateFlashCard(int id, Flashcard flashcard)
        {
            throw new NotImplementedException();
        }
    }
}
