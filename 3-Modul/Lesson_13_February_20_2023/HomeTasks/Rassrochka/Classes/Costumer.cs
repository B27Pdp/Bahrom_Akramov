using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_13_February_20_2023.HomeTasks.Rassrochka.Classes
{
    internal class Costumer
    {
        public Person? Person { get; set; }
        public Card? Card { get; set; }
        public string? Email { get; set; }
        public int Password { get; set; }   
        public Product? Product { get; set; } = null;
        public bool Blacklist { get; set; } = false;    
    }
}
