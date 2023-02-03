using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_1_February_2_2023.HomeTasks
{
    internal class Mathematics
    {
        public void sum(double a, double b)
        {
            Console.WriteLine("Yig'indisi => " + (a + b));
        }
        public void substract(double a, double b)
        {
            Console.WriteLine("Ayirmasi => " + (a - b));
        }
        public void multiply(double a, double b)
        {
            Console.WriteLine("Ko'paytmasi => " + (a * b));
        }
        public void devide(double a, double b)    
        {
            Console.WriteLine("Bo'linmasi => " + (a / b));
        }
    }
}
