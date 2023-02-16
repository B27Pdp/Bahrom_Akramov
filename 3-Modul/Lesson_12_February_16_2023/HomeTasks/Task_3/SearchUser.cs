using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_12_February_16_2023.HomeTasks.Task_3
{
    internal class SearchUser
    {
        public static string path = @"..\..\..\Lesson_12_February_16_2023\Jsons\users.json";
        public static string jsonToString = File.ReadAllText(path);
        public static List<User>? users = JsonConvert.DeserializeObject<List<User>>(jsonToString);

        public static void SearchUsers(string userName)
        {
            var user = users?.FirstOrDefault(x => (x.username== userName) || (x.email == userName));
            if (user != null)
            {
                string comp = JsonConvert.SerializeObject(user.company, Formatting.Indented);
                string geo = JsonConvert.SerializeObject(user.address.geo, Formatting.Indented);
                Console.WriteLine(comp);
                Console.WriteLine(geo);
            }
            else
            {
                Console.WriteLine("User mavjud emas");
            }
        }
    }
}
