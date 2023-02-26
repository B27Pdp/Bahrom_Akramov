using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_12_February_16_2023.HomeTasks.Threads.CRUD
{
    internal class Json_CRUD_Class
    {
        public static string pathJson = @"..\..\..\Lesson_12_February_16_2023\HomeTasks\Threads\Files\json_db.json";
        public static string? jsonToString;
        public static List<User>? users = new();


        public void AddUser(User user)
        {
            if (File.Exists(pathJson))
            {
                jsonToString = File.ReadAllText(pathJson);
                users = JsonConvert.DeserializeObject<List<User>>(jsonToString);
                user.Id = users.Last().Id + 1;
            }
            else
            {
                File.Create(pathJson).Dispose();
                user.Id = 1;
            }
            users?.Add(user);
            string listToJson = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(pathJson, listToJson);
            Console.WriteLine("User qo'shildi");
        }

        public void ShowUsers()
        {
            jsonToString = File.ReadAllText(pathJson);
            Console.WriteLine(jsonToString);
        }

        public void UpdateUser(int upId, User user)
        {
            if (!File.Exists(pathJson))
            {
                Console.WriteLine("Fayl bo'sh");
            }
            else
            {
                jsonToString = File.ReadAllText(pathJson);
                users = JsonConvert.DeserializeObject<List<User>>(jsonToString);

                var updateUser = users.Find(x => x.Id == upId);
                if (updateUser != null)
                {
                    updateUser.UserName = user.UserName;
                    updateUser.Password = user.Password;
                    updateUser.Email = user.Email;
                    updateUser.PhoneNumber = user.PhoneNumber;

                    string listToJson = JsonConvert.SerializeObject(users, Formatting.Indented);
                    File.WriteAllText(pathJson, listToJson);
                    Console.WriteLine("User tahrirlandi");
                }
                else
                {
                    Console.WriteLine("User mavjud emas");
                }
            }
        }

        public void DeleteUser(int delId)
        {
            if (!File.Exists(pathJson))
            {
                Console.WriteLine("Fayl bo'sh");
            }
            else
            {
                jsonToString = File.ReadAllText(pathJson);
                users = JsonConvert.DeserializeObject<List<User>>(jsonToString);

                var deleteUser = users.Find(x => x.Id == delId);
                if (deleteUser != null)
                {
                    users.Remove(deleteUser);
                    string listToJson = JsonConvert.SerializeObject(users, Formatting.Indented);
                    File.WriteAllText(pathJson, listToJson);
                    Console.WriteLine("User o'chirildi");
                }
                else
                {
                    Console.WriteLine("User mavjud emas");
                }
            }
        }
    }
}
