using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _3_Modul.Lesson_3_February_4_2023.HomeTasks.Chat_App
{
    delegate void OnClickSmsMassage(DateTime date, string name, string massage);

    internal class User
    {
        public event OnClickSmsMassage sendSMSMassage;

        public List<(DateTime, string, string)> massageList { get; set; }

        private string phoneNumber;
        private string name;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public User(string name, string phoneNumber)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            massageList = new List<(DateTime, string, string)>();
        }

        public void sendMassage()
        {
            Console.WriteLine("Xabarni kiritng: ");
            Console.Write(">> ");
            string text = Console.ReadLine() ?? "No Text";
            //massageList.Add((DateTime.Now, this.name, text));
            sendSMSMassage?.Invoke(DateTime.Now, name, text);
        }

        public void enterMassage(DateTime date, string name, string text)
        {
            massageList.Add((date, name, text));
        }

        public void showMassages()
        {
            foreach (var item in massageList)
            {
                Console.WriteLine($"{item.Item1}, {item.Item2}dan: {item.Item3}");
            }

            //massageList.ForEach(x => Console.WriteLine($"{x.Item1}, {x.Item2}dan: {x.Item3}"));
        }
    }
}
