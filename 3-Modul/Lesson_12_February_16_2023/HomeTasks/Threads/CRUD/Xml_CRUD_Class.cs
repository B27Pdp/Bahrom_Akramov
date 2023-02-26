using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _3_Modul.Lesson_12_February_16_2023.HomeTasks.Threads.Xml_Crud
{
    internal class Xml_CRUD_Class
    {
        public static string pathXML = @"..\..\..\Lesson_12_February_16_2023\HomeTasks\Threads\Files\xml_db.xml";
        List<User>? users = new();
        static XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
        public void AddUser(User user)
        {
            //XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            if (!File.Exists(pathXML))
            {
                user.Id = 1;
            }
            else
            {
                using (FileStream fs = new FileStream(pathXML, FileMode.Open))
                {
                    users = serializer.Deserialize(fs) as List<User>;
                    user.Id = users.Last().Id + 1;
                }
            }
            users?.Add(user);
            using (FileStream fs = new FileStream(pathXML, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, users);
            }
        }

        public void ShowUsers()
        {
            string xmlToString = File.ReadAllText(pathXML);
            Console.WriteLine(xmlToString);
        }

        public void UpdateUser(int upId, User user)
        {
            if (!File.Exists(pathXML))
            {
                Console.WriteLine("Fayl bo'sh");
            }
            else
            {
                using (FileStream fs = new FileStream(pathXML, FileMode.Open))
                {
                    users = serializer.Deserialize(fs) as List<User>;
                }

                var updateUser = users?.Find(x => x.Id == upId);
                if (updateUser != null)
                {
                    updateUser.UserName = user.UserName;
                    updateUser.Password = user.Password;
                    updateUser.Email = user.Email;
                    updateUser.PhoneNumber = user.PhoneNumber;

                    using (StreamWriter str = new StreamWriter(pathXML))
                    {
                        serializer.Serialize(str, users);
                    }
                    Console.WriteLine("User Tahrirlandi");
                }
                else
                {
                    Console.WriteLine("Bunday user mavjud emas");
                }
            }
        }

        public void DeleteUser(int delId)
        {
            if (!File.Exists(pathXML))
            {
                Console.WriteLine("Fayl bo'sh");
            }
            else
            {
                using (FileStream fs = new FileStream(pathXML, FileMode.Open))
                {
                    users = serializer.Deserialize(fs) as List<User>;
                }
                var deleteUser = users?.Find(x => x.Id == delId);
                if (deleteUser != null)
                {
                    users?.Remove(deleteUser);
                    using (StreamWriter str = new StreamWriter(pathXML))
                    {
                        serializer.Serialize(str, users);
                    }
                    Console.WriteLine("User o'chirildi");
                }
                else
                {
                    Console.WriteLine("Bunday user mavjud emas");
                }
            }
        }
    }
}
