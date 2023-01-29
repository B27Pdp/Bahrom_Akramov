namespace Bahrom_Akramov.Lesson_January_27_2023.HomeTasks.Dictionary
{
    internal class Person : IPerson<int>
    {
        private int id;
        private int age;
        private string name;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Age 
        {
            get { return age; }
            set { age = value; } 
        }
        public string Name 
        { 
            get { return name; }
            set { name = value; } 
        }
        public Person(int id, int age, string name)
        {
            Id = id;
            Age = age;
            Name = name;
        }

        public Person()
        {

        }

    }
}
