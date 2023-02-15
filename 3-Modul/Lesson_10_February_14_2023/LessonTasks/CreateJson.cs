using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_10_February_14_2023.LessonTasks
{
    internal class CreateJson
    {
        public static void RunProj()
        {
            string pathJson = @"..\..\..\Lesson_10_February_14_2023\Json_Folder\personJson.json";

            Person person = new()
            {
                Id = 1,
                FullName = "Bahrom",
                Address = "Andijon",
                Email = "Example@gmail.com",
                PhoneNumber = "1234567890"
            };

            string json = JsonConvert.SerializeObject(person, Formatting.Indented);

            if (!File.Exists(pathJson))
            {
                File.Create(pathJson).Dispose();
            }
            else
            {
                using (StreamWriter writer = File.AppendText(pathJson))
                {
                    writer.WriteLine(json);
                }
            }
            

            Console.WriteLine(json);
        }
    }
}
