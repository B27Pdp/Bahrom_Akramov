using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_12_February_16_2023.HomeTasks.Task_2
{
    internal class CRUD_Todo
    {
        public static string pathTodo = @"..\..\..\Lesson_12_February_16_2023\Jsons\todos.json";
        public static string jsonToString = File.ReadAllText(pathTodo);
        public static List<Todo>? todos = JsonConvert.DeserializeObject<List<Todo>>(jsonToString);

        public static void WorkList(int uId)
        {
            var workUserId = todos.FindAll(x => x.userId == uId).FindAll(z => z.completed);
            var workUserId2 = todos.FindAll(x => x.userId == uId).FindAll(z => !z.completed);
            string a = JsonConvert.SerializeObject(workUserId, Formatting.Indented);
            string b = JsonConvert.SerializeObject(workUserId2, Formatting.Indented);
            Console.WriteLine("Bajarilgan ishlar ro'yxati");
            Console.WriteLine(a);
            Console.WriteLine("====================================================================================");
            Console.WriteLine("Bajarilmagan ishlar ro'yxati");
            Console.WriteLine(b);
        }

        public static void AddNewTodo(Todo todo)
        {
            var todoId = todos.FirstOrDefault(x => x.id == todo.id);
            if (todoId == null)
            {
                todos.Add(todo);
                string addNewTodoString = JsonConvert.SerializeObject(todos, Formatting.Indented);
                File.WriteAllText(pathTodo, addNewTodoString);
                Console.WriteLine("Todo qo'shildi");
            }
            else
            {
                Console.WriteLine("Bunday id mavjud");
            }
        }

        public static void DeleteTodo(int id)
        {
            var todoId = todos.FirstOrDefault(x => x.id == id);
            if (todoId != null)
            {
                todos.Remove(todoId);
                string addNewTodoString = JsonConvert.SerializeObject(todos, Formatting.Indented);
                File.WriteAllText(pathTodo, addNewTodoString);
                Console.WriteLine("Todo o'chirildi");
            }
            else
            {
                Console.WriteLine("Bunday id mavjud emas");
            }
        }

        public static void UpdateTodo(int id, string todoTitle, bool todoCoomplete)
        {
            var todoId = todos.FirstOrDefault(x => x.id == id);
            if (todoId != null)
            {
                todoId.title = todoTitle;
                todoId.completed = todoCoomplete;
                string addNewTodoString = JsonConvert.SerializeObject(todos, Formatting.Indented);
                File.WriteAllText(pathTodo, addNewTodoString);
                Console.WriteLine("Todo yangilandi");
            }
            else
            {
                Console.WriteLine("Bunday id mavjud emas");
            }
        }

        public static void SearchTodo(string todoTitle)
        {
            var todoId = todos.FirstOrDefault(x => x.title == todoTitle);
            if (todoId != null)
            {
                string addNewTodoString = JsonConvert.SerializeObject(todoId, Formatting.Indented);
                Console.WriteLine(addNewTodoString);
            }
            else
            {
                Console.WriteLine("Bunday id mavjud emas");
            }

        }
    }
}
