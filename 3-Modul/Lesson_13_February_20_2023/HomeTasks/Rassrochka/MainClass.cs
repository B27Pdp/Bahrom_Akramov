using _3_Modul.Lesson_13_February_20_2023.HomeTasks.Rassrochka.Classes;
using _3_Modul.Lesson_13_February_20_2023.HomeTasks.Rassrochka.Enumlar;
using _3_Modul.Lesson_13_February_20_2023.HomeTasks.Rassrochka.Serializing_Class;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_13_February_20_2023.HomeTasks.Rassrochka
{
    internal class MainClass
    {

        public static void Run()
        {
            Console.WriteLine("Passport seriya raqamini kiriting: ");
            Console.Write(">> ");
            string? passId = Console.ReadLine();

        }

        public static Task<Person> IIVPerson(string PassportId)
        {
            Person? personn = new();
            Task.Run(() =>
            {

                JArray arrayPerson = JArray.Parse(File.ReadAllText(ClassSerializing.IIVPath));
                JToken? tokenPerson = arrayPerson.FirstOrDefault(x => (string?)x["PassportId"] == PassportId);

                if (tokenPerson != null)
                {
                    personn = tokenPerson.ToObject<Person>();
                }
            });
            return Task.FromResult(personn);
        }

        public async static Task<Employee> DSQPerson(string PassportId)
        {
            Employee? personn = new();
            await Task.Run(() =>
            {
                JArray arrayEmployee = JArray.Parse(File.ReadAllText(ClassSerializing.DSQPath));
                JToken? tokenEmployee = arrayEmployee.FirstOrDefault(x => (string?)x["Passport"] == PassportId);

                if (tokenEmployee != null)
                {
                    personn = tokenEmployee.ToObject<Employee>();
                }
            });
            return personn;
        }
        public static Task<Card> FindCard(string CardId)
        {
            Card? card = new();
            Task.Run(() =>
            {
                JArray arrayCard = JArray.Parse(File.ReadAllText(ClassSerializing.CardPath));
                JToken? tokenCard = arrayCard.FirstOrDefault(x => (string?)x["Id"] == CardId);
                if (tokenCard != null)
                {
                    card = tokenCard.ToObject<Card>();
                }
            });
            return Task.FromResult(card);
        }
        public async static Task<bool> FindEmail(string email)
        {
            Costumer? costum = new();
            await Task.Run(() =>
            {
                JArray arrayCostum = JArray.Parse(File.ReadAllText(ClassSerializing.CostumerPath));
                JToken? tokenCostum = arrayCostum.FirstOrDefault(x => (string?)x["Email"] == email);
                if (tokenCostum != null)
                {
                    costum = tokenCostum.ToObject<Costumer>();
                }
            });
            if (costum == null) return true;
            return false;
        }
        public async static Task<bool> FindEmailAnsPass(string email, int pass)
        {
            Costumer? costum = new();
            Costumer? costum2 = new();
            await Task.Run(() =>
            {
                JArray arrayCostum = JArray.Parse(File.ReadAllText(ClassSerializing.CostumerPath));
                JToken? tokenCostum = arrayCostum.FirstOrDefault(x => (string?)x["Email"] == email);
                if (tokenCostum != null)
                {
                    costum2 = tokenCostum.ToObject<Costumer>();
                    if (costum2.Password == pass)    
                    {
                        costum = tokenCostum.ToObject<Costumer>();
                    }
                }
            });
            if (costum == null) return true;
            return false;
        }
        public static async Task Employment(Employee employee)
        {
            string empToString = JsonConvert.SerializeObject(ClassSerializing.EmployeeList, Formatting.Indented);
            File.WriteAllText(ClassSerializing.DSQPath, empToString);
        }


        public async static Task Scoring(string PassportId)
        {
            await Task.Run(() =>
            {
                var person = IIVPerson(PassportId);
            });
            await Task.Run(() =>
            {
                var employee = DSQPerson(PassportId);
            });


        }
    }
}
