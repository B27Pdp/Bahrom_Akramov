﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_10_February_14_2023.HomeTasks
{
    internal class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Person(int id, string fullName, string address, string email, string phoneNumber)
        {
            Id = id;
            FullName = fullName;
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public Person()
        {

        }
    }
}
