using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bahrom_Akramov.Lesson_January_27_2023.HomeTasks.Dictionary
{
    internal interface IPerson<Tid> where Tid : struct
    {
        Tid Id { get; set; }
        int Age { get; set; }
        string Name { get; set; }
    }
}
