using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class StudentBooks
    {
        public Book book { get; set; }
        public DateTime DueDate { get; set; }
        public StudentBooks(Book _book, DateTime _dueDate)
        {
            book = _book;
            DueDate = _dueDate;
        }
    }
}
