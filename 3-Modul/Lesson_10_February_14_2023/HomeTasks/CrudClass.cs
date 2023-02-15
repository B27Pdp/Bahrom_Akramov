using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_10_February_14_2023.HomeTasks
{
    internal class CrudClass : ICrudInterfeys
    {
        public static string pathJson = @"..\..\..\Lesson_10_February_14_2023\Json_Folder\personJson.json";

        public static List<Person>? people;// = JsonConvert.DeserializeObject<List<Person>>(pathJson);

        public CrudClass()
        {
            people = new List<Person>();
            //if (File.Exists(pathJson))
            //{
            //    string json = File.ReadAllText(pathJson);
            //    people = JsonConvert.DeserializeObject<List<Person>>(json);
            //}
        }

        public void CreateJson(Person person)
        {
            if (File.Exists(pathJson))
            {
                string json = File.ReadAllText(pathJson);
                people = JsonConvert.DeserializeObject<List<Person>>(json);
            }
            else
            {
                File.Create(pathJson).Dispose();
            }
            var perId = people?.FirstOrDefault(x => x.Id == person.Id);
            if (perId == null)
            {
                people?.Add(person);
                string updateJson = JsonConvert.SerializeObject(people, Formatting.Indented);
                File.WriteAllText(pathJson, updateJson);
                Console.WriteLine("User qo'shildi");
                Thread.Sleep(500);
            }
            else
            {
                Console.WriteLine("User mavjud");
                Thread.Sleep(500);
            }


        }

        public void ReadJson(int id)
        {
            
        }

        public void ShowAllUsers()
        {
            //string JsonFile = JsonConvert.SerializeObject(pathJson, Formatting.Indented);
            //Console.WriteLine(JsonFile);
            foreach (var item in people)
            {
                Console.WriteLine($"Id: {item.Id}\nFullName: {item.FullName}\nAddress: {item.Address}\nEmail: {item.Email}\nPhone: {item.PhoneNumber}\n");
            }
        }

        public void UpdateJsonById(int upId)
        {
            var updateById = people.FirstOrDefault(x => x.Id == upId);
            if (updateById != null)
            {
                //Console.WriteLine("Id ni kiriting: ");
                //Console.Write(">> ");
                //string? id = Console.ReadLine();
                Console.WriteLine("Yangi F.I.O ni kiriting: ");
                Console.Write(">> ");
                string? name = Console.ReadLine();
                Console.WriteLine("Yangi Address ni kiriting: ");
                Console.Write(">> ");
                string? address = Console.ReadLine();
                Console.WriteLine("Yangi Email ni kiriting: ");
                Console.Write(">> ");
                string? email = Console.ReadLine();
                Console.WriteLine("Yangi Telefon nomerni kiriting: ");
                Console.Write(">> ");
                string? phone = Console.ReadLine();
                //if (id != "")
                //    updateById.Id = int.Parse(id);
                if (name != "")
                    updateById.FullName = name;
                if (address != "")
                    updateById.Address = address;
                if (email != "")
                    updateById.Email = email;
                if (phone != "")
                    updateById.PhoneNumber = phone;
                string upJson = JsonConvert.SerializeObject(people, Formatting.Indented);
                File.WriteAllText(pathJson, upJson);
                //File.WriteAllText(pathJson, people.ToString());
                Console.WriteLine("User o'zgartirildi");
                Thread.Sleep(500);

            }
            else
            {
                Console.WriteLine("Bunday Foydalanuvchi yo'q");
                Thread.Sleep(500);
            }
        }

        public void UpdateJsonByName(string name)
        {
            throw new NotImplementedException();
        }

        public void DeleteJsonById(int delId)
        {
            var delById = people.FirstOrDefault(x => (int)x.Id == delId);
            if (delById != null)
            {
                people.Remove(delById);
                string deleteJson = JsonConvert.SerializeObject(people, Formatting.Indented);
                File.WriteAllText(pathJson, deleteJson);
                //File.WriteAllText(pathJson, people.ToString());
                Console.WriteLine("User o'chirildi");
                Thread.Sleep(500);
            }
            else
            {
                Console.WriteLine("Bunday Foydalanuvchi yo'q");
                Thread.Sleep(500);
            }
        }

        public void DeleteJsonByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
