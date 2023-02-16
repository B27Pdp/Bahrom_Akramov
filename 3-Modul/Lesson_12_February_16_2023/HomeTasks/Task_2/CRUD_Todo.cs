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
            var workUserId = todos.FindAll(x => x.userId == uId);
            foreach (var item in workUserId)
            {
                Console.WriteLine($"userId: {item.userId}\nid: {item.id}\ntitle: {item.title}\ncompleated: {item.completed}\n");
            }
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

    }
}
