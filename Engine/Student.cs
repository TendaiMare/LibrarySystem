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
            foreach (StudentBooks _sb in this.studentBooks)
            {
                if (studentBook.book.ID==_sb.book.ID)
                {
                    return (dateOfReturn - _sb.DueDate).Days;
                }                
            }
            return 0;
        }

        public void FineCheckAndIssueFinesIfOverDue(StudentBooks studentBook, DateTime dateOfReturn)
        {
            if (this.DaysLate(studentBook,dateOfReturn)>=1)
            {
                StudentFines newFine = new StudentFines(studentBook, dateOfReturn);
                studentFines.Add(new StudentFines(studentBook, dateOfReturn));
            }
        }

        public void ReturnBook(StudentBooks sb, DateTime dateOfReturn)
        {            
            var d = this.studentBooks.Find(r=>r.book.ID==sb.book.ID);
            d.Returned = true;
            d.ReturnDate = dateOfReturn;
            FineCheckAndIssueFinesIfOverDue(sb, dateOfReturn);

            foreach (StudentBooks _sb in this.studentBooks)
            {
                if (d.book.ID==_sb.book.ID)
                {
                    d.book.IncreamentQuantity();
                    break;
                }
            }
        }        

        public bool BorrowBook(Book book)
        {
            if (book.Quantity>0)
            {
                book.DecreamentQuantity();
                StudentBooks mySb = new StudentBooks(book, DateTime.Now.AddDays(7),false);
                this.studentBooks.Add(mySb);
                return true;
            }
            return false;
        }

    }
}
