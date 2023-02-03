namespace _3_Modul.Lesson_1_February_2_2023.LessonTasks
{
    internal class Delegates
    {
        public delegate void ExampleDelegate();
            
        public delegate void ExampleDelegateWithDelegate(ExampleDelegate d);

        public delegate void ExampleDelegateWithParam(int a, int b, ExampleDelegateWithDelegate d);
    }
}
