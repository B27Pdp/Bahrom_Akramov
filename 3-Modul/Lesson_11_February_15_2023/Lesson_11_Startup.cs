using _3_Modul.Lesson_10_February_14_2023.HomeTasks;
using _3_Modul.Lesson_11_February_15_2023.HomeTasks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_11_February_15_2023
{
    internal class Lesson_11_Startup
    {
        public static void Run()
        {
            CRUD_Shop crud = new();
            Header header = new() { name = "salom", value = "dunyo" };

            //CRUD_Shop.AddHeader("4836ed06-23cf-490c-936c-5186294095f9",header);


            //string textJson = JsonConvert.SerializeObject(CRUD_Shop.GetRoot(), Formatting.Indented);
            //Console.WriteLine(textJson);


            //Folder folder = new() { containerId = "123", sortNum = 456, name = "Folder Name", _id = "1", created = DateTime.Now };
            //CRUD_Shop.AddFolder(folder);


            //Request request = new()
            //{
            //    containerId = "4561",
            //    sortNum = 123,
            //    colId = "4154",
            //    name = "Boltavoy",
            //    url = "example.com",
            //    method = "POST",
            //    modified = DateTime.Now,
            //    created = DateTime.Now,
            //    _id = "741"
            //};
            //request.AddHeader(header);
            //CRUD_Shop.AddNewRequest(request);


            //CRUD_Shop.RemoveHeader("4836ed06-23cf-490c-936c-5186294095f9", "as");


            CRUD_Shop.UpdateFolder("1", "123456", "222222", "Yangi Name");

        }

    }
}
