using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public  class Library
    {
       
        public static readonly List<Book> Books = new List<Book>();
        public static readonly List<Employee> Employees = new List<Employee>();
        

        public static void PopulateBooks()
        {
            

            Books.Add(new Book(1,"Mpho Search","Gilbert"));
            Books.Add(new Book(2,"The Holy Bible","NIV"));
            Books.Add(new Book(3,"c# in depth","The # Masters"));
            Books.Add(new Book(4,"The Holy Grail","Charlie Stout"));
            Books.Add(new Book(5,"Nice Cars","Jon Lewi"));
            Books.Add(new Book(6, "Java Unravelled", "Tauris"));
            Books.Add(new Book(7, "How to bake", "Candy Frew"));
            Books.Add(new Book(8, "Swimming in deep Water", "Matt Deq"));
            Books.Add(new Book(9, "Lovers dating Tips", "Margaret Flir"));
            Books.Add(new Book(10, "Mangos in Summer", "Struff"));
            Books.Add(new Book(11, "Music to the heart", "Billy"));
            Books.Add(new Book(12, "Sleep walking", "Bob Chiffy"));
            Books.Add(new Book(13, "Zen lifestyle", "Viltip Qwerty"));

        }
        public static void PopulateEmployees()
        {
            Employees.Add(new Employee(1, "Themba","Lancing","Male",23,"Themba","Themba@123"));
            Employees.Add(new Employee(2, "John", "Trunk", "Male", 38,"MrJohn","John@123"));
            Employees.Add(new Employee(3, "Stella", "Moon", "Female", 54,"Stells","Stella@123"));
            Employees.Add(new Employee(4, "Edward", "Star", "Male", 25,"Eddy","Edward@123"));
            Employees.Add(new Employee(5, "Lisa", "Bundy", "Female", 49,"Lisa","Lisa@123"));
        }
        public static readonly List<Student> Students = new List<Student>();
        public static void PopulateStudents()
        {
            Students.Add(new Student(1, "Monalisa", "Enerst", "Male", 23));
            Students.Add(new Student(2, "Fredrick", "Makanda", "Male", 38));
            Students.Add(new Student(3, "Thomas", "Rusvato", "Male", 54));
            Students.Add(new Student(4, "Levlin", "Horrid", "Male", 25));
            Students.Add(new Student(5, "Devin", "Rice", "Male", 49));
            Students.Add(new Student(6, "Yatil", "Sausage", "Male", 38));
            Students.Add(new Student(7, "Shadreck", "Wine", "Male", 54));
            Students.Add(new Student(8, "Valentine", "Loving", "Male", 25));
            Students.Add(new Student(9, "Enoch", "Mixer", "Male", 49));
            Students.Add(new Student(10, "Florence", "Waiter", "Female", 54));
            Students.Add(new Student(11, "Sharon", "Lilgith", "Female", 25));
            Students.Add(new Student(12, "Lindiwe", "McTavish", "Female", 49));
            Students.Add(new Student(13, "Sthabile", "Gumede", "Female", 38));
            Students.Add(new Student(14, "Nobuhle", "Nehandiro", "Female", 54));
            Students.Add(new Student(15, "Tererai", "Mashava", "Female", 25));
        }

    }
}
