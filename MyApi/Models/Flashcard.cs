using MyApi.Enums;

namespace MyApi.Models
{
    public class Flashcard
    {        
        public int Id { get; set; }
        public string Polish { get; set; } = string.Empty;
        public string English { get; set; } = string.Empty;
        public RepetitionEnum Repetition { get; set; }
        public DateTime? LastTouch { get; set; }
        public bool IsCompleted { get; set; }
        public bool WasLastTouchSuccessful { get; set; }
    }
}
