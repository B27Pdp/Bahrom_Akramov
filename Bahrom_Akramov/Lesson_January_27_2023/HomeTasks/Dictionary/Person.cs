namespace Bahrom_Akramov.Lesson_January_27_2023.HomeTasks.Dictionary
{
    internal class Person : IPerson<int>
    {
        public int Id
        {
            get { return Id; }
            set { Id = value; }
        }
        public byte Age 
        {
            get { return Age; }
            set { Age = value; } 
        }
        public string Name 
        { 
            get { return Name; }
            set { Name = value; } 
        }
    }
}
