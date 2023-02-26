using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_14_February_23_2023.LessonTasks
{
    internal class LINQ_Example
    {
        public static void Run()
        {
            //string satr = "   Hello     World     !   ";
            //string output = string.Join(" ", satr.Split().Where(s => !string.IsNullOrWhiteSpace(s)));
            //Console.WriteLine(output);

            var result = from s in Employee.GetEmployees()
                         select s.ID;
            foreach (var item in result)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
            var res = from s in Employee.GetEmployees()
                      select new
                      {
                          FirstName = s.FirstName,
                          LastName = s.LastName,
                          Salary = s.Salary
                          
                      };
            foreach (var item in res)
            {
                Console.WriteLine(item.FirstName+", "+item.LastName+", "+item.Salary);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            var methodSyn = Employee.GetEmployees().Select(x => x.ID);
            foreach (var item in methodSyn)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
            var methodSyn2 = Employee.GetEmployees().Select(x => new
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                Salary = x.Salary
            });
            foreach (var item in methodSyn2)
            {
                Console.WriteLine(item.FirstName + ", " + item.LastName + ", " + item.Salary);
            }

            var selectEmp = from emp in Employee.GetEmployees().Select((value, index) => new { value, index })
                            select new
                            {
                                id = emp.index,
                                fName = emp.value.FirstName,
                                lName = emp.value.LastName,
                                salary = emp.value.Salary
                            };
            foreach (var item in selectEmp)
            {
                Console.WriteLine($"id: {item.id}, firs name: {item.fName}, last name: {item.lName}, Salary: {item.salary}");
            }
        }
    }

    public class EmployeeBasicInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
    }
    public class Emp
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee {ID = 101, FirstName = "Preety", LastName = "Tiwary", Salary = 60000 },
                new Employee {ID = 102, FirstName = "Priyanka", LastName = "Dewangan", Salary = 70000 },
                new Employee {ID = 103, FirstName = "Hina", LastName = "Sharma", Salary = 80000 },
                new Employee {ID = 104, FirstName = "Anurag", LastName = "Mohanty", Salary = 90000 },
                new Employee {ID = 105, FirstName = "Sambit", LastName = "Satapathy", Salary = 100000 },
                new Employee {ID = 106, FirstName = "Sushanta", LastName = "Jena", Salary = 160000 }
            };
            return employees;
        }
    }
}
