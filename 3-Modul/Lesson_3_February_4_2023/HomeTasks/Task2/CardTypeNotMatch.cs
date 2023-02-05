using System.Runtime.Serialization;

namespace _3_Modul.Lesson_3_February_4_2023.HomeTasks.Task2
{
    [Serializable]
    internal class CardTypeNotMatch : Exception
    {
        public CardTypeNotMatch()
        {
        }

        public CardTypeNotMatch(string? message) : base(message)
        {
        }

        public CardTypeNotMatch(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CardTypeNotMatch(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}