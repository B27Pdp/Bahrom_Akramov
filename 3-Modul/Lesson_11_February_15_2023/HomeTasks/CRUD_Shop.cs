using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_11_February_15_2023.HomeTasks
{
    internal class CRUD_Shop
    {
        static string pathJson = @"..\..\..\Lesson_11_February_15_2023\Jsons\shop.json";
        static string pathJson2 = @"..\..\..\Lesson_11_February_15_2023\Jsons\shop2.json";

        public static Root? GetRoot()
        {
            if (File.Exists(pathJson))
            {
                return JsonConvert.DeserializeObject<Root>(File.ReadAllText(pathJson));
            }
            return null;
        }

        //public void Serialize(Root root)
        //{
        //    if (!File.Exists(pathJson))
        //    {
        //        File.Create(pathJson).Dispose();
        //    }
        //    File.WriteAllText(pathJson2, JsonConvert.SerializeObject(root, Formatting.Indented));
        //}

        // Qo'shish

        public static void AddNewRoot(Root root)
        {
            if (!File.Exists(pathJson))
            {
                File.Create(pathJson).Dispose();
            }
            File.WriteAllText(pathJson, JsonConvert.SerializeObject(root, Formatting.Indented));
        }
        public static void AddNewRequest(Request request)
        {
            string joinStringJson = File.ReadAllText(pathJson);
            Root? root = JsonConvert.DeserializeObject<Root>(joinStringJson);
            root?.requests?.Add(request);
            File.WriteAllText(pathJson, JsonConvert.SerializeObject(root, Formatting.Indented));
        }
        public static void AddNewFolder(Folder folder)
        {
            string joinStringJson = File.ReadAllText(pathJson);
            Root? root = JsonConvert.DeserializeObject<Root>(joinStringJson);
            root?.folders?.Add(folder);
            File.WriteAllText(pathJson, JsonConvert.SerializeObject(root, Formatting.Indented));
        }
        public static void AddNewHeader(string id, Header header)
        {
            string joinStringJson = File.ReadAllText(pathJson);
            Root? root = JsonConvert.DeserializeObject<Root>(joinStringJson);
            var AddHeader = root?.requests?.FirstOrDefault(x => x._id == id);
            if (AddHeader != null)
            {
                AddHeader?.headers?.Add(header);
                File.WriteAllText(pathJson, JsonConvert.SerializeObject(root, Formatting.Indented));
            }
            else
            {
                Console.WriteLine("Bunday request mavjud emas");
            }
        }


        // O'chirish

        public static void RemoveFile(string id)
        {
            string joinStringJson = File.ReadAllText(pathJson);
            Root? root = JsonConvert.DeserializeObject<Root>(joinStringJson);
            var remFile = root?.folders?.FirstOrDefault(x => x._id == id);
            if (remFile != null)
            {
                root?.folders?.Remove(remFile);
                File.WriteAllText(pathJson, JsonConvert.SerializeObject(root, Formatting.Indented));
            }
            else
            {
                Console.WriteLine("Bunday request mavjud emas");
            }
        }

        public static void RemoveRequest(string id)
        {
            string joinStringJson = File.ReadAllText(pathJson);
            Root? root = JsonConvert.DeserializeObject<Root>(joinStringJson);
            var remRequest = root?.requests?.FirstOrDefault(x => x._id == id);
            if (remRequest != null)
            {
                root?.requests?.Remove(remRequest);
                File.WriteAllText(pathJson, JsonConvert.SerializeObject(root, Formatting.Indented));
            }
            else
            {
                Console.WriteLine("Bunday request mavjud emas");
            }
        }

        public static void RemoveHeader(string id, string name)
        {
            string joinStringJson = File.ReadAllText(pathJson);
            Root? root = JsonConvert.DeserializeObject<Root>(joinStringJson);
            var RemoveHeader = root?.requests?.FirstOrDefault(x => x._id == id);
            if (RemoveHeader != null)
            {
                var remHeader = RemoveHeader?.headers?.FirstOrDefault(a => a.name == name);
                if (remHeader != null)
                {
                    RemoveHeader?.headers?.Remove(remHeader);
                    File.WriteAllText(pathJson, JsonConvert.SerializeObject(root, Formatting.Indented));
                    Console.WriteLine("Header o'chirildi");
                }
                else
                {
                    Console.WriteLine("Bunday name mavjud emas");
                }
            }
            else
            {
                Console.WriteLine("Bunday name mavjud emas");
            }
        }

        // O'zgartirish
        public static void UpdateFolder(string id, string contId, string sNum, string name)
        {
            string joinStringJson = File.ReadAllText(pathJson);
            Root? root = JsonConvert.DeserializeObject<Root>(joinStringJson);
            var UpFolder = root?.folders?.FirstOrDefault(x => x._id == id);
            if (UpFolder != null)
            {
                if (contId != "") UpFolder.containerId = contId;
                if (sNum != "") UpFolder.sortNum = int.Parse(sNum);
                if (name!= null) UpFolder.name = name;
                UpFolder.created = DateTime.Now;
                File.WriteAllText(pathJson, JsonConvert.SerializeObject(root, Formatting.Indented));
                Console.WriteLine("Folder yangilandi");
            }
            else
            {
                Console.WriteLine("Bunday Folder mavjud emas");
            }
        }
        //public static void UpdateRequest()


    }
}
