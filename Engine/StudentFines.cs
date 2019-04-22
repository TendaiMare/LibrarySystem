using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class StudentFines
    {

        private decimal _penaltyRate;
        public decimal PenaltyRate
        {
            get { return _penaltyRate; }
            private  set { _penaltyRate = Convert.ToDecimal(2.3); }
        }
        
        public StudentBooks book { get; set; }
        public DateTime DateBookWasReturned { get; set; }

        private decimal _FineAmount;

        public decimal FineAmount
        {
            get 
            {return _FineAmount;}
            private set { _FineAmount = value; }
        }

        public StudentFines(StudentBooks _book,DateTime _returnDate)
        {
            book = _book;
            DateBookWasReturned = _returnDate;
            FineAmount = GetFineAmount(book, _returnDate);            
        }

        private decimal GetFineAmount(StudentBooks bk,DateTime rd)
        {  
           return (bk.DueDate - rd).Days * PenaltyRate;
        }  
    }
}
