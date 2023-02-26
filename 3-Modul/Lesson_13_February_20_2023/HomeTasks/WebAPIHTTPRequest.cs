using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _3_Modul.Lesson_13_February_20_2023.HomeTasks
{
    internal class WebAPIHTTPRequest
    {
        public static void Run()
        {
            Console.WriteLine("Run Method Started...");
            Console.Write("Enter the Name: ");
            string? name = Console.ReadLine();
            SomeMethod(name);
            Console.WriteLine("Run Method End");
            Console.ReadKey();
        }
        public async static void SomeMethod(string name)
        {
            Console.WriteLine("Some Method Started...");
            var GreetingsMassage = await Greetings(name);
            Console.WriteLine($"\n{GreetingsMassage}");
            Console.WriteLine("Some Method End");
        }
        public async static Task<string> Greetings(string name)
        {
            string message = string.Empty;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:58937/");
                HttpResponseMessage response = await client.GetAsync($"api/greetings/{name}");
                message = await response.Content.ReadAsStringAsync();
            }
            return message;
        }
    }
}
