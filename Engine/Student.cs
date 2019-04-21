using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Student
    {

        public Student(int id,string name,string surname,string gender,int age)
        {
            ID = id;
            Name = name;
            Surname = surname;
            Gender = gender;
            Age = age;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public List<StudentBooks> StudentBooks = new List<StudentBooks>();
    }
}
