using _3_Modul.Lesson_13_February_20_2023.HomeTasks.Rassrochka.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_13_February_20_2023.HomeTasks.Rassrochka.Serializing_Class
{
    internal class ClassSerializing
    {
        public static string IIVPath = @"..\..\..\Lesson_13_February_20_2023\HomeTasks\Rassrochka\Json_Files\IIVData.json";
        public static string DSQPath = @"..\..\..\Lesson_13_February_20_2023\HomeTasks\Rassrochka\Json_Files\DSQData.json";
        public static string CostumerPath = @"..\..\..\Lesson_13_February_20_2023\HomeTasks\Rassrochka\Json_Files\CostumerData.json";
        public static string ProductsPath = @"..\..\..\Lesson_13_February_20_2023\HomeTasks\Rassrochka\Json_Files\ProductsData.json";
        public static string CardPath = @"..\..\..\Lesson_13_February_20_2023\HomeTasks\Rassrochka\Json_Files\CardData.json";

        public static List<Person> PersonList = new List<Person>();
        public static List<Employee> EmployeeList = new List<Employee>();
        public static List<Costumer> CostumerList = new List<Costumer>();
        public static List<Product> ProductList = new List<Product>();
        public static List<Card> CardList = new List<Card>();

        public async static void IIVSerializing()
        {
            await Task.Run(() =>
            {
                if (!File.Exists(IIVPath))
                {
                    File.Create(IIVPath).Dispose();
                }
                else
                {
                    PersonList = JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText(IIVPath)) ?? new();
                }
            });

        }
        public static async void DSQSerializing()
        {
            await Task.Run(() =>
            {
                if (!File.Exists(DSQPath))
                {
                    File.Create(DSQPath).Dispose();
                }
                else
                {
                    EmployeeList = JsonConvert.DeserializeObject<List<Employee>>(File.ReadAllText(DSQPath)) ?? new();
                }
            });

        }
        public static async void CostumerSerializing()
        {
            await Task.Run(() =>
            {
                if (!File.Exists(CostumerPath))
                {
                    File.Create(CostumerPath).Dispose();
                }
                else
                {
                    CostumerList = JsonConvert.DeserializeObject<List<Costumer>>(File.ReadAllText(CostumerPath)) ?? new();
                }
            });
        }
        public static async void ProductSerializing()
        {
            await Task.Run(() =>
            {
                if (!File.Exists(ProductsPath))
                {
                    File.Create(ProductsPath).Dispose();
                }
                else
                {
                    ProductList = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText(ProductsPath)) ?? new();
                }
            });
        }
        public static async void CardSerializing()
        {
            await Task.Run(() =>
            {
                if (!File.Exists(CardPath))
                {
                    File.Create(CardPath).Dispose();
                }
                else
                {
                    CardList = JsonConvert.DeserializeObject<List<Card>>(File.ReadAllText(CardPath)) ?? new();
                }
            });
        }

        public static void AddPerson(Person person)
        {
            PersonList.Add(person);
            Employee employee = new();
            employee.Person = person;
            EmployeeList.Add(employee);
            string listToStringIIV = JsonConvert.SerializeObject(PersonList, Formatting.Indented);
            string listToStringDSQ = JsonConvert.SerializeObject(EmployeeList, Formatting.Indented);
            File.WriteAllText(IIVPath, listToStringIIV);
            File.WriteAllText(DSQPath, listToStringDSQ);
        }

        public static void AddEmployee(Employee employee)
        {
            EmployeeList.Add(employee);
        }

        public static void AddCostumer(Costumer costumer)
        {
            CostumerList.Add(costumer);
            string listToStringCostum = JsonConvert.SerializeObject(CostumerList, Formatting.Indented);
            File.WriteAllText(CostumerPath, listToStringCostum);
        }

    }
}
