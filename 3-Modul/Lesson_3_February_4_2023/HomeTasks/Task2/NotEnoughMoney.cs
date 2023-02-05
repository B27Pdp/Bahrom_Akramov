using System.Runtime.Serialization;

namespace _3_Modul.Lesson_3_February_4_2023.HomeTasks.Task2
{
    [Serializable]
    internal class NotEnoughMoney : Exception
    {
        public NotEnoughMoney()
        {
        }

        public NotEnoughMoney(string? message) : base(message)
        {
        }

        public NotEnoughMoney(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NotEnoughMoney(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}