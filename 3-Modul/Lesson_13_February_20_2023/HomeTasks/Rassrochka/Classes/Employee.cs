using _3_Modul.Lesson_13_February_20_2023.HomeTasks.Rassrochka.Enumlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_13_February_20_2023.HomeTasks.Rassrochka.Classes
{
    internal class Employee
    {
        public Person? Person { get; set; }
        public WorkPlase? Workplace { get; set; } = null;
        public double? Salary { get; set; } = null;
    }
}
