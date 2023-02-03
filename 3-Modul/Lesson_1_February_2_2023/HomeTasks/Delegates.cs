using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_1_February_2_2023.HomeTasks
{
    internal class Delegates
    {
        public delegate void Mathematic(double a, double b);

        public delegate Tuple<int, int> MinAndMaxValues(List<int> list);
    }
}
