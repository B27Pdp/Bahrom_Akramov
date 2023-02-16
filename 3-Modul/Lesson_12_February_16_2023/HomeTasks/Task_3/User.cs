using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_12_February_16_2023.HomeTasks.Task_3
{
    internal class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public Address address { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public Company company { get; set; }
    }

    internal class Address
    {
        public string street { get; set; }
        public string suite { get; set; }
        public string city { get; set; }
        public string ziocode { get; set; }
        public Geo geo { get; set; }
    }

    internal class Geo
    {
        public string lat { get; set; }
        public string lng { get; set; }
    }

    internal class Company
    {
        public string name { get; set; }
        public string catchPhrase { get; set; }
        public string bs { get; set; }
    }
}
