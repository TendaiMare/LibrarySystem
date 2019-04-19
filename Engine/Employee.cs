﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Employee
    {
        public Employee(int id, string name, string surname, string gender, int age, string username, string password)
        {
            ID = id;
            Name = name;
            Surname = surname;
            Gender = gender;
            Age = age;
            Username = username;
            Password = password;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }

}
