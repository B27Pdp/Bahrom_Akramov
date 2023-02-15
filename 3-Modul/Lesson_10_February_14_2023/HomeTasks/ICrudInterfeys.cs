using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_10_February_14_2023.HomeTasks
{
    internal interface ICrudInterfeys
    {
        void CreateJson(Person person);
        void ReadJson(int id);
        void UpdateJsonById(int id);
        void UpdateJsonByName(string name);
        void DeleteJsonById(int id);
        void DeleteJsonByName(string name);
    }
}
