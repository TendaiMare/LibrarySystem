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

        public List<StudentBooks> studentBooks = new List<StudentBooks>();
        public List<StudentFines> studentFines = new List<StudentFines>();


        public int DaysLate( StudentBooks studentBook, DateTime dateOfReturn)
        {
            var u = this.studentBooks.Find(r => r.book.ID == studentBook.book.ID);
            DateTime myDueDate = u.DueDate;
            return (dateOfReturn - myDueDate).Days;
        }
        public void FineCheckAndIssueFinesIfOverDue(StudentBooks studentBook, DateTime dateOfReturn)
        {
            if (this.DaysLate(studentBook,dateOfReturn)>=1)
            {
                StudentFines newFine = new StudentFines(studentBook, dateOfReturn);
                studentFines.Add(new StudentFines(studentBook, dateOfReturn));
            }
        }
        public void ReturnBook(StudentBooks sb)
        {
            var d = this.studentBooks.Find(r=>r.book.ID==sb.book.ID);
            this.studentBooks.Remove(d);           
        }
    }
}
